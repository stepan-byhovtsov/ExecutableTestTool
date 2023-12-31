﻿namespace ExecutableTestTool.Libs;

internal static class DataAmountConverter
{
   public static (double scale, DataAmountUnit unit) Minimize(long bytes)
   {
      if (bytes < (long)1e3)
         return (bytes, DataAmountUnit.B);
      if (bytes < (long)1e6)
         return (bytes / 1e3, DataAmountUnit.Kb);
      if (bytes < (long)1e9)
         return (bytes / 1e6, DataAmountUnit.Mb);
      if (bytes < (long)1e12)
         return (bytes / 1e9, DataAmountUnit.Gb);
      
      return (bytes / 1e12, DataAmountUnit.Tb);
   }
}

internal enum DataAmountUnit : long
{
   B =  (long) 1e0,
   Kb = (long) 1e3,
   Mb = (long) 1e6,
   Gb = (long) 1e9,
   Tb = (long) 1e12,
}
