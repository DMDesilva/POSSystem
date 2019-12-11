using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ErrorHandler
{
    public static class ErrorHandler
    {

        public static void Log(string methodName, string Err, string owner)
        {
            try
            {
              //  EdXpro.Helpers.AzureStorage.AzureStorageHelper.writeLog(methodName, Err, owner);
                //string FinalPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                //FinalPath = Path.Combine(FinalPath, "AppLogs", DateTime.Now.Year.ToString(), DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString("00") + DateTime.Now.Day.ToString("00"));
                //if (!Directory.Exists(FinalPath)) Directory.CreateDirectory(FinalPath);
                //FinalPath = Path.Combine(FinalPath, DateTime.Now.ToString("yyyyMMdd_HH") + ".log");
                //using (StreamWriter sw = File.AppendText(FinalPath))
                //{
                //    sw.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + ", " + methodName + "," + Err);
                //}

            }
            catch (Exception)
            {

                //  throw;
            }






        }

    }
}
