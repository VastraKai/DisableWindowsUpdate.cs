﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Util
{
    public static int ProcessStart(string file, string args)
    {
        
        try
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = file,
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                }
            };
            proc.Start();
           
            proc.WaitForExit();
            /*while (!proc.StandardOutput.EndOfStream)
            {
                line = 
                line = proc.StandardError.ReadLine();
            }*/
            
            

            return proc.ExitCode;
        } catch (Exception ex)
        {
            Console.WriteLine("" + ex, 15);
            return 1;
        }
    }
}