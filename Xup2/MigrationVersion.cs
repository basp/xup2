namespace Xup2
{
    using System;
    using System.Linq;

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

        public static MigrationVersion Parse(string s)
        {
            var parts = s
                .Split(MigrationNameGrammar.VERSION_SEPARATORS)
                .Select(int.Parse)
                .ToArray();

            return new MigrationVersion(parts);
        }

        private static string JoinParts(params int[] parts) =>
            string.Join(".", parts);
    }
}