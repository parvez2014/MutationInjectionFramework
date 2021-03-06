/*
    comedi/drivers/adl_pci7432.c

    Hardware comedi driver fot PCI7432 Adlink card
    Copyright (C) 2004 Michel Lachine <mike@mikelachaine.ca>

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

*/
/*
Driver: adl_pci7432
Description: Driver for the Adlink PCI-7432 64 ch. isolated digital io board
Devices: [ADLink] PCI-7432 (adl_pci7432)
Author: Michel Lachaine <mike@mikelachaine.ca>
Status: experimental
Updated: Mon, 14 Apr 2008 15:08:14 +0100

Configuration Options:
  [0] - PCI bus of device (optional)
  [1] - PCI slot of device (optional)
  If bus/slot is not specified, the first supported
  PCI device found will be used.
*/

#include "../comedidev.h"
#include <linux/kernel.h>

#define PCI7432_DI      0x00
#define PCI7432_DO	    0x00

#define PCI_DEVICE_ID_PCI7432 0x7432

static int adl_pci7432_do_insn_bits(struct comedi_device *dev,
                                    struct comedi_subdevice *s,
                                    struct comedi_insn *insn,
                                    unsigned int *data)
{
    printk(KERN_DEBUG "comedi: pci7432_do_insn_bits called\n");
    printk(KERN_DEBUG "comedi: data0: %8x data1: %8x\n", data[0], data[1]);

    if (data[0])
    {
        s->state &= ~data[0];
        s->state |= (data[0] & data[1]);

        printk(KERN_DEBUG "comedi: out: %8x on iobase %4lx\n", s->state,
               dev->iobase + PCI7432_DO);
        outl(s->state & 0xffffffff, dev->iobase + PCI7432_DO);
    }
    return insn->n;
}

static int adl_pci7432_di_insn_bits(struct comedi_device *dev,
                                    struct comedi_subdevice *s,
                                    struct comedi_insn *insn,
                                    unsigned int *data)
{
    printk(KERN_DEBUG "comedi: pci7432_di_insn_bits called\n");
    printk(KERN_DEBUG "comedi: data0: %8x data1: %8x\n", data[0], data[1]);

    data[1] = inl(dev->iobase + PCI7432_DI) & 0xffffffff;
    printk(KERN_DEBUG "comedi: data1 %8x\n", data[1]);

    return insn->n;
}

static struct pci_dev *adl_pci7432_find_pci(struct comedi_device *dev,
        struct comedi_devconfig *it)
{
    struct pci_dev *pcidev = NULL;
    int bus = it->options[0];
    int slot = it->options[1];

    for_each_pci_dev(pcidev)
    {
        if (pcidev->vendor != PCI_VENDOR_ID_ADLINK ||
                pcidev->device != PCI_DEVICE_ID_PCI7432)
            continue;
        if (bus || slot)
        {
            /* requested particular bus/slot */
            if (pcidev->bus->number != bus ||
                    PCI_SLOT(pcidev->devfn) != slot)
                continue;
        }
        return pcidev;
    }
    printk(KERN_ERR
           "comedi%d: no supported board found! (req. bus/slot : %d/%d)\n",
           dev->minor, bus, slot);
    return NULL;
}

static int adl_pci7432_attach(struct comedi_device *dev,
                              struct comedi_devconfig *it)
{
    struct pci_dev *pcidev;
    struct comedi_subdevice *s;
    int ret;

    printk(KERN_INFO "comedi%d: attach adl_pci7432\n", dev->minor);

    dev->board_name = "pci7432";

    ret = comedi_alloc_subdevices(dev, 2);
    if (ret)
        return ret;

    pcidev = adl_pci7432_find_pci(dev, it);
    if (!pcidev)
        return -EIO;
    comedi_set_hw_dev(dev, &pcidev->dev);

    if (comedi_pci_enable(pcidev, "adl_pci7432") < 0)
    {
        printk(KERN_ERR "comedi%d: Failed to enable PCI device and request regions\n",
               dev->minor);
        return -EIO;
    }
    dev->iobase = pci_resource_start(pcidev, 2);
    printk(KERN_INFO "comedi: base addr %4lx\n", dev->iobase);

    s = dev->subdevices + 0;
    s->type = COMEDI_SUBD_DI;
    s->subdev_flags = SDF_READABLE | SDF_GROUND | SDF_COMMON;
    s->n_chan = 32;
    s->maxdata = 1;
    s->len_chanlist = 32;
    s->io_bits = 0x00000000;
    s->range_table = &range_digital;
    s->insn_bits = adl_pci7432_di_insn_bits;

    s = dev->subdevices + 1;
    s->type = COMEDI_SUBD_DO;
    s->subdev_flags = SDF_WRITABLE | SDF_GROUND | SDF_COMMON;
    s->n_chan = 32;
    s->maxdata = 1;
    s->len_chanlist = 32;
    s->io_bits = 0xffffffff;
    s->range_table = &range_digital;
    s->insn_bits = adl_pci7432_do_insn_bits;

    printk(KERN_DEBUG "comedi%d: adl_pci7432 attached\n", dev->minor);
    return 0;
}

static void adl_pci7432_detach(struct comedi_device *dev)
{
    struct pci_dev *pcidev = comedi_to_pci_dev(dev);

    if (pcidev)
    {
        if (dev->iobase)
            comedi_pci_disable(pcidev);
        pci_dev_put(pcidev);
    }
}

static struct comedi_driver adl_pci7432_driver =
{
    .driver_name	= "adl_pci7432",
    .module		= THIS_MODULE,
    .attach		= adl_pci7432_attach,
    .detach		= adl_pci7432_detach,
};

static int __devinit adl_pci7432_pci_probe(struct pci_dev *dev,
        const struct pci_device_id *ent)
{
    return comedi_pci_auto_config(dev, &adl_pci7432_driver);
}

static void __devexit adl_pci7432_pci_remove(struct pci_dev *dev)
{
    comedi_pci_auto_unconfig(dev);
}

static DEFINE_PCI_DEVICE_TABLE(adl_pci7432_pci_table) =
{
    { PCI_DEVICE(PCI_VENDOR_ID_ADLINK, PCI_DEVICE_ID_PCI7432) },
    { 0 }
};
MODULE_DEVICE_TABLE(pci, adl_pci7432_pci_table);

static struct pci_driver adl_pci7432_pci_driver =
{
    .name		= "adl_pci7432",
    .id_table	= adl_pci7432_pci_table,
    .probe		= adl_pci7432_pci_probe,
    .remove		= __devexit_p(adl_pci7432_pci_remove),
};
module_comedi_pci_driver(adl_pci7432_driver, adl_pci7432_pci_driver);

MODULE_AUTHOR("Comedi http://www.comedi.org");
MODULE_DESCRIPTION("Comedi low-level driver");
MODULE_LICENSE("GPL");
