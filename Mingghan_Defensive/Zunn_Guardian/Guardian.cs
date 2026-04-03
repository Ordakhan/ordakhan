// Arquivo: C:\th1eros\Ordakhan\Mingghan_Defensive\Zunn_Guardian\Guardian.cs
using System;
using System.Diagnostics;
using System.Threading;

namespace Zunn_Guardian
{
    class Guardian
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- ORDAKHAN - ZUNN GUARDIAN v0.1 ---");
            string processName = "Zunn_Engine";

            while (true)
            {
                Process[] pname = Process.GetProcessesByName(processName);
                if (pname.Length == 0)
                {
                    Console.WriteLine($"[!] ALERTA: {processName} offline! Reiniciando unidade...");
                    // Aqui no futuro dispararemos o reinício automático
                }
                else
                {
                    // Log silencioso de integridade
                    Console.Title = $"[ORDHAKAN] Guardian Active - {processName} OK";
                }
                Thread.Sleep(5000); // Verifica a cada 5 segundos
            }
        }
    }
}