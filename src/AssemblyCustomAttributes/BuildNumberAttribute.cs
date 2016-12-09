using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssemblyCustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class BuildNumberAttribute : Attribute
    {
        private long _buildNumber;
        public BuildNumberAttribute(long buildNumber)
        {
            if (buildNumber <= 0)
            {
                throw new ArgumentException(nameof(buildNumber));
            }
            _buildNumber = buildNumber;
        }

        public long BuildNumber { get { return _buildNumber; } }
    }
}
