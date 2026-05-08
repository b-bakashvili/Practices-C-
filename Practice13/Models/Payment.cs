using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice13.Models;

internal class Payment
{
    public Guid Id;
    public Guid FromAccountId;
    public Guid ToAccountId;
    public int Amount;
    public string Currency;
    public DateTime CreatedOn;
}
