using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssemblyCustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class BuildDateAttribute : Attribute
    {
        private DateTime _buildDate;
        public DateTime BuildDate
        {
            get { return _buildDate; }
        }
        public BuildDateAttribute(long buildDateTicks)
        {
            if (buildDateTicks <= 0)
            {
                throw new ArgumentNullException(nameof(buildDateTicks));
            }
            _buildDate  = new DateTime(buildDateTicks).ToUniversalTime();
        }
    }
}
