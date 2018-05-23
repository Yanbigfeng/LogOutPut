using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace LogOutPut
{
    /// <summary>
    /// NLog插件日志使用
    /// </summary>

    public class Nlog
    {
        /// <summary>
        /// 获取Nlog实例
        /// </summary>
        private static readonly Logger nLog = LogManager.GetCurrentClassLogger();

        public static void main()
        {
            nLog.Trace("Trace Message");
            nLog.Debug("Debug Message");
            nLog.Info("Info Message");
            nLog.Error("Error Message");
            nLog.Fatal("Fatal Message");
        }

        public static void Trace(string value) {
            nLog.Trace(value);
        }

        public static void Debug(string value)
        {
            nLog.Trace(value);
        }

        public static void Info(string value)
        {
            nLog.Trace(value);
        }

        public static void Error(string value)
        {
            nLog.Trace(value);
        }

        public static void Fatal(string value)
        {
            nLog.Trace(value);
        }
    }
}
