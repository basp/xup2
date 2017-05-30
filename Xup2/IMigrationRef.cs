namespace Xup2
{
    public interface IMigrationRef
    {
        bool Repeatable { get; }

        MigrationVersion Version { get; }

        string Description { get; }
    }
}