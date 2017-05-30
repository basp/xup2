using System;

namespace Xup2
{
    public class RepeatableMigrationRef : IMigrationRef
    {
        public bool Repeatable => throw new NotImplementedException();

        public MigrationVersion Version => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();
    }
}