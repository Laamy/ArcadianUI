using System;
using System.Windows.Forms;

public class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(true);
        Application.Run(new DebugForm());
    }
}