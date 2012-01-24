using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace QuartzTypeLib
{
    [Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IVideoWindow
    {
        int Owner { get; set; }

        void get_AutoShow(
            [Out] long AutoShow);

        void get_BackgroundPalette(
            [Out] long pBackgroundPalette);

        void get_BorderColor(
            [Out] long pColor);

        void get_Caption(
            [Out, MarshalAs(UnmanagedType.BStr)]
            string strCaption);

        void get_FullScreenMode(
            [Out] long FullScreenMode);

        void get_Height(
            [Out] long pHeight);

        void get_Left(
            [Out] long pLeft);

        void get_MessageDrain(
            [In] IntPtr Drain);

        void get_Owner(
            [Out] IntPtr pOwner);

        void get_Top(
            [Out] long pTop);

        void get_Visible(
            [Out] long pVisible);

        void get_Width(
            [Out] long pWidth);

        void get_WindowState(
            [Out] long WindowState);

        void get_WindowStyle(
            [Out] long pWindowStyle);

        void get_WindowStyleEx(
            [Out] // retval ??
            long pWindowStyleEx);

        void GetMaxIdealImageSize(
            [Out] long pWidth,
            [Out] long pHeight);

        void GetMinIdealImageSize(
            [Out] long pWidth,
            [Out] long pHeight);

        void GetRestorePosition(
            [Out] long pLeft,
            [Out] long pTop,
            [Out] long pWidth,
            [Out] long pHeight);

        void GetWindowPosition(
            [Out] long pLeft,
            [Out] long pTop,
            [Out] long pWidth,
            [Out] long pHeight);

        void HideCursor(
            [In] long HideCursor);

        void IsCursorHidden(
            [Out] long CursorHidden);

        void NotifyOwnerMessage(
            [In] IntPtr hwnd,
            [In] long uMsg,
            [In] IntPtr wParam,
            [In] IntPtr lParam);

        void put_AutoShow(
            [In] long AutoShow);

        void put_BackgroundPalette(
            [In] long BackgroundPalette);

        void put_BorderColor(
            [In] long Color);

        void put_Cation(
            [In, MarshalAs(UnmanagedType.BStr)] string strCaption);

        void put_FullScreenMode(
            [In] long FullScreenMode);

        void put_Height(
            [In] long Height);

        void put_Left(
            [In] long Left);

        void put_MessageDrain(
            [In] IntPtr Drain);

        void put_Owner(
            [In] IntPtr Owner);

        void put_Top(
            [In] long Top);

        void put_Visible(
            [In] long Visible);

        void put_Width(
            [In] long Width);

        void put_WindowState(
            [In] long WindowState);

        void put_WindowStyle(
            [In] long WindowStyle);

        void put_WindowStyleEx(
            [In] long WindowStyleEx);

        void SetWindowForeground(
            long Focus);

        void SetWindowPosition(
            [In] long Left,
            [In] long Top,
            [In] long Width,
            [In] long Height);
    }
}
