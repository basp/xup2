using System;

namespace Xup2
{
    public class MigrationVersion : IComparable<MigrationVersion>
    {
        public MigrationVersion(params int[] parts)
            : this(JoinParts(parts), parts)
        {
        }

        public MigrationVersion(string displayName, params int[] parts)
        {
            this.DisplayName = displayName;
            this.Parts = parts;
        }

        public string DisplayName
        {
            get;
        }

        public int[] Parts
        {
            get;
        }

        public int CompareTo(MigrationVersion other) =>
            throw new NotImplementedException();

        public override string ToString() =>
            string.IsNullOrWhiteSpace(this.DisplayName)
                ? JoinParts(this.Parts)
                : $"{DisplayName} ({JoinParts(this.Parts)})";

        private static string JoinParts(params int[] parts) =>
            string.Join(".", parts);
    }
}