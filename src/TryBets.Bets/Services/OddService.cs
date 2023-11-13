using System.Net.Http;
namespace TryBets.Bets.Services;

public class OddService : IOddService
{
    private readonly HttpClient _client;
    public OddService(HttpClient client)
    {
        _client = client;
    }

    public async Task<object> UpdateOdd(int MatchId, int TeamId, decimal BetValue)
    {
        string url = $"http://localhost:5004/odd/{MatchId}/{TeamId}/{BetValue}";

        var response = await _client.PatchAsync(url, null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();


    }
}