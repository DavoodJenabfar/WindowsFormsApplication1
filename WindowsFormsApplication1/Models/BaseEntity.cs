using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseEntity:System.Object
    {
public BaseEntity()
:base()
            {
                id= System.Guid.NewGuid();
            }

public System.Guid id { get; set; }
    }
}
