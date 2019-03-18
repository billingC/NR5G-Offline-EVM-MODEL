using System;
using System.Windows.Forms;

namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
   class Program
   {
      [STAThread]
      static void Main()
      {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRFmxSettings());
            //RFmxNRULModAccSingleCarrier rFmxNRULModAccSingleCarrier = new RFmxNRULModAccSingleCarrier();
            //rFmxNRULModAccSingleCarrier.Run();
      }
   }
}
