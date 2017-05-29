namespace Xup2
{
    using System.Collections.Generic;

    public interface IMigrationResolver
    {
        IEnumerable<IResolvedMigration> ResolveMigrations();
    }
}