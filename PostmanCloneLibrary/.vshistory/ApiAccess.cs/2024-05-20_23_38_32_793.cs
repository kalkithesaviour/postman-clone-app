using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(
        string url,
        string bodyContent,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
    )
    {
        StringContent stringContent = new(bodyContent, Encoding.UTF8, "application/json");
        return await CallApiAsync(url, stringContent, action, formatOutput);
    }

    public async Task<string> CallApiAsync(
        string url,
        HttpContent? bodyContent = null,
        HttpAction action = HttpAction.GET,
        bool formatOutput = true
    )
    {
        HttpResponseMessage response;

        switch (action)
        {
            case HttpAction.GET:
                response = await client.GetAsync(url);
                break;
            case HttpAction.POST:
                response = await client.PostAsync(url, bodyContent);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();

            if (formatOutput)
            {
                JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });
            }

            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url))
        {
            return false;
        }

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }
}
