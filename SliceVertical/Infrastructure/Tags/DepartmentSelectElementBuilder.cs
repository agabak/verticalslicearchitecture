using SliceVertical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SliceVertical.Infrastructure.Tags
{
    public class DepartmentSelectElementBuilder : EntitySelectElementBuilder<Department>
    {
        protected override int GetValue(Department instance)
        {
            return instance.Id;
        }

        protected override string GetDisplayValue(Department instance)
        {
            return instance.Name;
        }
    }
}
