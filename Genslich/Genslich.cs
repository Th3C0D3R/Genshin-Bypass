﻿using System;
using System.Diagnostics;

namespace Genslich
{
    public static class Genslich
    {
        static Genslich()
        {
            ConsoleHelper.CreateConsole();
            Console.WriteLine("DLL MAIN (Only DLL_PROCESS_ATTACH) :D");
        }
    }
}
