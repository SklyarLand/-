using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director                            //командует
    {
        public void Construct(IBuilder builder)         //пинает строителя

        {
            builder.Build();
        }
    }
}
