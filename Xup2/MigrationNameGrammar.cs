namespace Xup2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using Sprache;

    public static class MigrationNameGrammar
    {
        public static readonly char[] PREFIXES = new[] { 'V', 'R' };

        public static readonly string SEPARATOR = "__";

        public static readonly char[] VERSION_SEPARATORS =  new[] { '.', '_' };

        public static IMigrationRef ParseMigration(this string s) => 
            Migration.Parse(s);

        private static Parser<IMigrationRef> Migration =>
            RepeatableMigration.Or(VersionedMigration);

        private static Parser<IMigrationRef> RepeatableMigration =>
            from prefix in Prefix
            from __ in Separator
            from description in Description.Select(x => x.HumanizeDescription())
            from suffix in Suffix
            select new RepeatableMigrationRef(description);

        private static Parser<IMigrationRef> VersionedMigration =>
            from prefix in Prefix
            from version in Version
            from __ in Separator
            from description in Description
            from suffix in Suffix
            select new VersionedMigrationRef(version, description);

        private static Parser<string> Description =>
            Parse.LetterOrDigit.Or(Parse.Char('_')).Many().Except(Suffix).Text();

        private static Parser<string> Suffix => 
            Parse.String(".sql").Text();

        private static Parser<char> Prefix => 
            Parse.Chars(PREFIXES);

        private static Parser<string> Separator =>
            Parse.String(SEPARATOR).Text();

        private static Parser<char> VersionSeparator =>
            Parse.Chars(VERSION_SEPARATORS).Except(Separator);

        private static Parser<MigrationVersion> Version =>
            from s in Parse.Digit.Or(VersionSeparator).AtLeastOnce().Text()
            select MigrationVersion.Parse(s);
    }
}