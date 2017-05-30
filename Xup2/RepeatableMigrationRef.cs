using System;

namespace Xup2
{
    public class RepeatableMigrationRef : IMigrationRef
    {
        public RepeatableMigrationRef(string description)
        {
            this.Description = description;
        }

        public bool Repeatable => true;

        public MigrationVersion Version => null;

        public string Description { get; }

        public override string ToString() => this.Description;
    }
}