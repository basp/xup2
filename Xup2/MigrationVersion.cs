using System;

namespace Xup2
{
    public class MigrationVersion : IComparable<MigrationVersion>
    {
        public MigrationVersion(params int[] parts)
        {
            this.Parts = parts;
        }


        public int[] Parts
        {
            get;
        }

        public int CompareTo(MigrationVersion other) =>
            throw new NotImplementedException();

        public override string ToString() => JoinParts(this.Parts);
                
        private static string JoinParts(params int[] parts) =>
            string.Join(".", parts);
    }
}