using System;

namespace MultipleTargetLibrary
{
    public class FrameworkHelper
    {
        public static FrameworkType GetFrameworkType()
        {
#if NET5_0
            return FrameworkType.Net5;
#elif NETCOREAPP3_1
            return FrameworkType.NetCore3_1;
#else
            return FrameworkType.None;
#endif
        }
    }
}