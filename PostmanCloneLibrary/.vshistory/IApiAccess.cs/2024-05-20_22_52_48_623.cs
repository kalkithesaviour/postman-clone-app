namespace PostmanCloneLibrary;

public interface IApiAccess
{
    Task<string> CallApiAsync(string url, bool formatOutput = true, HttpAction action = HttpAction.GET);
    Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true);
    bool IsValidUrl(string url);
}