using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.View
{
    using Contracts.ViewModel;

    public interface IView
    {
        IViewModel ViewModel { get; }
    }
}
