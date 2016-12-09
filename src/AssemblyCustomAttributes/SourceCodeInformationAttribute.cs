using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssemblyCustomAttributes
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public sealed class SourceCodeInformationAttribute : Attribute
    {
        private string _branchName;
        private string _commitHash;
        public SourceCodeInformationAttribute(string branchName, string commitHash)
        {
            if (string.IsNullOrWhiteSpace(branchName))
            {
                throw new ArgumentNullException(nameof(branchName));
            }

            if (string.IsNullOrWhiteSpace(commitHash))
            {
                throw new ArgumentNullException(nameof(commitHash));
            }

            _branchName = branchName;
            _commitHash = commitHash;
        }

        public string BranchName { get { return _branchName; } }

        public string CommitHash { get { return _commitHash; } }
    }
}
