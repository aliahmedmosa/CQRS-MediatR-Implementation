﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Features.Products.Requests.Command
{
    public class DeleteProductCommand : IRequest
    {
        public int Id { get; set; }
    }
}
