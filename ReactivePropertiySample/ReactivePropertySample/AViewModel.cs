using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactivePropertySample
{
    public class AViewModel
    {
        public ReactiveProperty<string> Name { get; }
        public ReactiveProperty<string> Memo { get; }
        public ReactiveCommand DoSomethingCommand { get; }

        public AViewModel()
        {
            Name = new ReactiveProperty<string>()
                .SetValidateNotifyError(x => string.IsNullOrEmpty(x) ? "Invalid value" : null);
            Memo = new ReactiveProperty<string>()
                .SetValidateNotifyError(x => string.IsNullOrEmpty(x) ? "Invalid value" : null);
            DoSomethingCommand = new[]
                {
                Name.ObserveHasErrors,
                Memo.ObserveHasErrors,
            }
                .CombineLatestValuesAreAllFalse()
                .ToReactiveCommand()
                .WithSubscribe(() => { Memo.Value = Memo.Value + Name.Value; });
        }
    }
}
