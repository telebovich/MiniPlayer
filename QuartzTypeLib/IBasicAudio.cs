using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace QuartzTypeLib
{
    [Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IBasicAudio
    {
        void get_Balance(
            [Out]
            long plBalance);

        void get_Volume(
            [Out]
            long plVolume);

        void put_Balance(
            [In]
            long lBalance);

        void put_Volume(
            [In]
            long lVolume);
    }
}
