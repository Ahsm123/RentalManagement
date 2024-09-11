using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.ClassLibrary;

public class Horse : IRentable
{
    public string Breed { get; set; }
    public bool IsAvailable { get; set; }
    public string Name { get; set; }

    public Horse(string name, string breed = null)
    {
        Name = name;
        Breed = breed;
        IsAvailable = true;
    }

    public void Rent()
    {
        if (IsAvailable == true)
        {
            IsAvailable = false;
        }
    }
}
