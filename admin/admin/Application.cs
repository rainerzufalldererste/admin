using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin
{
  public static class Application
  {
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("Usage:\nadmin executable.exe arg0 arg1 arg2 ...");
        return;
      }

      string path = args[0].Trim('\"');
      string strargs = "";
      int num = 0;

      args.ToList().ForEach(arg =>
      {
        if (num++ > 0)
          strargs += arg + " ";
      });

      strargs = strargs.TrimEnd(' ');

      ElevateRightsWindows.RunElevated(path, strargs);
    }
  }
}
