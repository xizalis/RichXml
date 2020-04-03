using System;
using System.ComponentModel;

namespace RichXml.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        //---

        protected void AppInvoke(Action a)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(a);
        }
    }
}