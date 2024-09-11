using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.ClassLibrary;

public interface IRentable
{
    public bool IsAvailable { get; set; }

    public void Rent();
}
