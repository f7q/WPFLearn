using System;
using System.Windows;
using System.Windows.Input;

namespace WpfControlLibrary
{
    class Class2 : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("こんにちは世界");
        }
    }
}
