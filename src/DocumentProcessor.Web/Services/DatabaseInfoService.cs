namespace DocumentProcessor.Web.Services;

public class DatabaseInfoService
{
    public string DatabaseType { get; set; } = "PostgreSQL";
    public string SecretName { get; set; } = "None";
    public string HostAddress { get; set; } = "Unknown";
}
