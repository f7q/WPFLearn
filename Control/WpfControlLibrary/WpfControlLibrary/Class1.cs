using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System.Reactive.Linq;

namespace WpfControlLibrary
{
    public class Class1ViewModel
    {
        public ReactiveProperty<string> Name { get; }
        public Class1ViewModel()
        {

        }
    }
}
