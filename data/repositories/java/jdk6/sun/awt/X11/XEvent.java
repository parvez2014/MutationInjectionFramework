// This file is an automatically generated file, please do not edit this file, modify the WrapperGenerator.java file instead !

package sun.awt.X11;

import sun.misc.*;

import java.util.logging.*;
public class XEvent extends XWrapperBase
{
    private Unsafe unsafe = XlibWrapper.unsafe;
    private final boolean should_free_memory;
    public static int getSize()
    {
        return 96;
    }
    public int getDataSize()
    {
        return getSize();
    }

    long pData;

    public long getPData()
    {
        return pData;
    }


    public XEvent(long addr)
    {
        log.finest("Creating");
        pData=addr;
        should_free_memory = false;
    }


    public XEvent()
    {
        log.finest("Creating");
        pData = unsafe.allocateMemory(getSize());
        should_free_memory = true;
    }


    public void dispose()
    {
        log.finest("Disposing");
        if (should_free_memory)
        {
            log.finest("freeing memory");
            unsafe.freeMemory(pData);
        }
    }
    public int get_type()
    {
        log.finest("");
        return (Native.getInt(pData+0));
    }
    public void set_type(int v)
    {
        log.finest("");
        Native.putInt(pData+0, v);
    }
    public XAnyEvent get_xany()
    {
        log.finest("");
        return new XAnyEvent(pData + 0);
    }
    public XKeyEvent get_xkey()
    {
        log.finest("");
        return new XKeyEvent(pData + 0);
    }
    public XButtonEvent get_xbutton()
    {
        log.finest("");
        return new XButtonEvent(pData + 0);
    }
    public XMotionEvent get_xmotion()
    {
        log.finest("");
        return new XMotionEvent(pData + 0);
    }
    public XCrossingEvent get_xcrossing()
    {
        log.finest("");
        return new XCrossingEvent(pData + 0);
    }
    public XFocusChangeEvent get_xfocus()
    {
        log.finest("");
        return new XFocusChangeEvent(pData + 0);
    }
    public XExposeEvent get_xexpose()
    {
        log.finest("");
        return new XExposeEvent(pData + 0);
    }
    public XGraphicsExposeEvent get_xgraphicsexpose()
    {
        log.finest("");
        return new XGraphicsExposeEvent(pData + 0);
    }
    public XNoExposeEvent get_xnoexpose()
    {
        log.finest("");
        return new XNoExposeEvent(pData + 0);
    }
    public XVisibilityEvent get_xvisibility()
    {
        log.finest("");
        return new XVisibilityEvent(pData + 0);
    }
    public XCreateWindowEvent get_xcreatewindow()
    {
        log.finest("");
        return new XCreateWindowEvent(pData + 0);
    }
    public XDestroyWindowEvent get_xdestroywindow()
    {
        log.finest("");
        return new XDestroyWindowEvent(pData + 0);
    }
    public XUnmapEvent get_xunmap()
    {
        log.finest("");
        return new XUnmapEvent(pData + 0);
    }
    public XMapEvent get_xmap()
    {
        log.finest("");
        return new XMapEvent(pData + 0);
    }
    public XMapRequestEvent get_xmaprequest()
    {
        log.finest("");
        return new XMapRequestEvent(pData + 0);
    }
    public XReparentEvent get_xreparent()
    {
        log.finest("");
        return new XReparentEvent(pData + 0);
    }
    public XConfigureEvent get_xconfigure()
    {
        log.finest("");
        return new XConfigureEvent(pData + 0);
    }
    public XGravityEvent get_xgravity()
    {
        log.finest("");
        return new XGravityEvent(pData + 0);
    }
    public XResizeRequestEvent get_xresizerequest()
    {
        log.finest("");
        return new XResizeRequestEvent(pData + 0);
    }
    public XConfigureRequestEvent get_xconfigurerequest()
    {
        log.finest("");
        return new XConfigureRequestEvent(pData + 0);
    }
    public XCirculateEvent get_xcirculate()
    {
        log.finest("");
        return new XCirculateEvent(pData + 0);
    }
    public XCirculateRequestEvent get_xcirculaterequest()
    {
        log.finest("");
        return new XCirculateRequestEvent(pData + 0);
    }
    public XPropertyEvent get_xproperty()
    {
        log.finest("");
        return new XPropertyEvent(pData + 0);
    }
    public XSelectionClearEvent get_xselectionclear()
    {
        log.finest("");
        return new XSelectionClearEvent(pData + 0);
    }
    public XSelectionRequestEvent get_xselectionrequest()
    {
        log.finest("");
        return new XSelectionRequestEvent(pData + 0);
    }
    public XSelectionEvent get_xselection()
    {
        log.finest("");
        return new XSelectionEvent(pData + 0);
    }
    public XColormapEvent get_xcolormap()
    {
        log.finest("");
        return new XColormapEvent(pData + 0);
    }
    public XClientMessageEvent get_xclient()
    {
        log.finest("");
        return new XClientMessageEvent(pData + 0);
    }
    public XMappingEvent get_xmapping()
    {
        log.finest("");
        return new XMappingEvent(pData + 0);
    }
    public XErrorEvent get_xerror()
    {
        log.finest("");
        return new XErrorEvent(pData + 0);
    }
    public XKeymapEvent get_xkeymap()
    {
        log.finest("");
        return new XKeymapEvent(pData + 0);
    }
    public long get_pad(int index)
    {
        log.finest("");
        return Native.getLong(pData + 0+index*Native.getLongSize());
    }
    public void set_pad(int index, long v)
    {
        log.finest("");
        Native.putLong(pData+0 + index*Native.getLongSize(), v);
    }
    public long get_pad()
    {
        log.finest("");
        return pData+0;
    }


    String getName()
    {
        return "XEvent";
    }


    String getFieldsAsString()
    {
        String ret="";

        ret += ""+"type = " + XlibWrapper.eventToString[get_type()] +", ";
        ret += ""+"xany = " + get_xany() +", ";
        ret += ""+"xkey = " + get_xkey() +", ";
        ret += ""+"xbutton = " + get_xbutton() +", ";
        ret += ""+"xmotion = " + get_xmotion() +", ";
        ret += ""+"xcrossing = " + get_xcrossing() +", ";
        ret += ""+"xfocus = " + get_xfocus() +", ";
        ret += ""+"xexpose = " + get_xexpose() +", ";
        ret += ""+"xgraphicsexpose = " + get_xgraphicsexpose() +", ";
        ret += ""+"xnoexpose = " + get_xnoexpose() +", ";
        ret += ""+"xvisibility = " + get_xvisibility() +", ";
        ret += ""+"xcreatewindow = " + get_xcreatewindow() +", ";
        ret += ""+"xdestroywindow = " + get_xdestroywindow() +", ";
        ret += ""+"xunmap = " + get_xunmap() +", ";
        ret += ""+"xmap = " + get_xmap() +", ";
        ret += ""+"xmaprequest = " + get_xmaprequest() +", ";
        ret += ""+"xreparent = " + get_xreparent() +", ";
        ret += ""+"xconfigure = " + get_xconfigure() +", ";
        ret += ""+"xgravity = " + get_xgravity() +", ";
        ret += ""+"xresizerequest = " + get_xresizerequest() +", ";
        ret += ""+"xconfigurerequest = " + get_xconfigurerequest() +", ";
        ret += ""+"xcirculate = " + get_xcirculate() +", ";
        ret += ""+"xcirculaterequest = " + get_xcirculaterequest() +", ";
        ret += ""+"xproperty = " + get_xproperty() +", ";
        ret += ""+"xselectionclear = " + get_xselectionclear() +", ";
        ret += ""+"xselectionrequest = " + get_xselectionrequest() +", ";
        ret += ""+"xselection = " + get_xselection() +", ";
        ret += ""+"xcolormap = " + get_xcolormap() +", ";
        ret += ""+"xclient = " + get_xclient() +", ";
        ret += ""+"xmapping = " + get_xmapping() +", ";
        ret += ""+"xerror = " + get_xerror() +", ";
        ret += ""+"xkeymap = " + get_xkeymap() +", ";
        ret += "{" + get_pad(0) + " " + get_pad(1) + " " + get_pad(2) + " " + get_pad(3) + " " + get_pad(4) + " " + get_pad(5) + " " + get_pad(6) + " " + get_pad(7) + " " + get_pad(8) + " " + get_pad(9) + " " + get_pad(10) + " " + get_pad(11) + " " + get_pad(12) + " " + get_pad(13) + " " + get_pad(14) + " " + get_pad(15) + " " + get_pad(16) + " " + get_pad(17) + " " + get_pad(18) + " " + get_pad(19) + " " + get_pad(20) + " " + get_pad(21) + " " + get_pad(22) + " " + get_pad(23) + " " + "}";
        return ret;
    }


}



