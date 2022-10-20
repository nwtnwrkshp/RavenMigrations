namespace Raven.Migrations
{
  public interface IMigrationRecordStore
  {
    IMigrationRecord Load(string migrationId);
    void Store(MigrationRecord record);
    void Delete(IMigrationRecord record);
  }
}