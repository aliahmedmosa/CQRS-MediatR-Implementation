using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Features.Categories.Requests.Command
{
    public class DeleteCategoryCommand :IRequest
    {
        public int Id { get; set; }
    }
}
