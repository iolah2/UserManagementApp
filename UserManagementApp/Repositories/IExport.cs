namespace UserManagementApp.Repositories
{
    internal interface IExport
    {
        bool ExportDataList(string filePath);
    }
}