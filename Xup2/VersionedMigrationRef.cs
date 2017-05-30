using System;

namespace Xup2
{
    public class VersionedMigrationRef : IMigrationRef
    {
        public VersionedMigrationRef(MigrationVersion version, string description)
        {
            this.Version = version;
            this.Description = description;
        }

        public bool Repeatable => false;

        public MigrationVersion Version
        {
            get;
        }

        public string Description
        {
            get;
        }

        public override string ToString() => 
            $"{Description} ({Version})";
    }
}