using Converter.src;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        // Управление дополнительными формами приложения
        private static FormAbout _aboutForm;
        private static FormHistory _historyForm;
        public static FormAbout AboutForm
        {
            get
            {
                if (_aboutForm == null) _aboutForm = new FormAbout();
                return _aboutForm;
            }
        }

        public static FormHistory HistoryForm
        {
            get
            {
                if (_historyForm == null) _historyForm = new FormHistory();
                return _historyForm;
            }
        }

        public static string HistoryFile { get { return "history.txt"; } }

        private static History _history;
        public static History HstoryObject
        {
            get
            {
                if (_history == null) _history = new History();
                return _history;
            }
        }

        public static string DecimalPoint
        {
            get { return CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator; }
        }
    }
}
