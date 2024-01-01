using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.DTOs.Common
{
    public abstract class BaseDto<T>
    {
        public T Id { get; set; }
    }
}
