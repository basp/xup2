using System;

namespace Xup2
{
    public class VersionedMigrationRef : IMigrationRef
    {
        public VersionedMigrationRef()
        {
            
        }

        public VersionedMigrationRef(string version, string description)
        {
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
    }
}