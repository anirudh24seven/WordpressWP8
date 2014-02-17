using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WordPressWP8.Commands
{
    public class LaunchWebBrowserCommand : ICommand
    {
        #region events

        public event EventHandler CanExecuteChanged;

        #endregion

        #region methods

        public bool CanExecute(object parameter)
        {
            string url = parameter as string;
            if (string.IsNullOrEmpty(url))
            {
                return false;
            }

            Uri testUri;
            bool canExecute = Uri.TryCreate(url, UriKind.Absolute, out testUri);

            return canExecute;
        }

        #endregion
    }
}
