namespace Xup2
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SqlMigrationResolver : IMigrationResolver
    {
        private const string SqlMigrationPrefix = "V";
        private const string RepeatableSqlMigrationPrefix = "R";

        private readonly IScanner scanner;

        private readonly IEnumerable<string> locations;

        public SqlMigrationResolver(
            IScanner scanner,
            IEnumerable<string> locations)
        {
            this.scanner = scanner;
            this.locations = locations;
        }

        public IEnumerable<IResolvedMigration> ResolveMigrations()
        {
            throw new NotImplementedException();
        }

        private void ScanForMigrations(
            string path,
            ICollection<IResolvedMigration> migrations,
            string prefix,
            string separator,
            string suffix,
            bool repeatable)
        {
            var resources = this.scanner.ScanForResources(path, prefix, suffix);
            foreach(var res in resources)
            {
                var fileName = Path.GetFileName(res.Path);

                // TODO: Skip callbacks

                // var migration = new ResolvedMigration();
            }
        }
    }
}