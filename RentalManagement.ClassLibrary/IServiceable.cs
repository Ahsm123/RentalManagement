using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.ClassLibrary;

public interface IServiceable
{
    public bool NeedsService { get; }
    public void ResetNeedForService();
}
