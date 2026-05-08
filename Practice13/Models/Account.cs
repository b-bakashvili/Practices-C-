using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13.Models;

internal class Account
{
    public Guid Id;
    public Guid ClientId;
    public string AccountNumber; // ფორმატი: 0000000001GEL (10 ციფრი + ვალუტა)
    public string AccountName;
    public string Currency;
    public int Balance;
    public DateTime CreatedOn;
}
