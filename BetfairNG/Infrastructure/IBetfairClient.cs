using BetfairNG.API;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BetfairNG
{
    public interface IBetfairClient
    {
        Task<BetfairServerResponse<CancelExecutionReport>> CancelOrders(string marketId = null, IList<CancelInstruction> instructions = null, string customerRef = null);
        Task<BetfairServerResponse<AccountDetailsResponse>> GetAccountDetails();
        Task<BetfairServerResponse<AccountFundsResponse>> GetAccountFunds(Wallet wallet);
        Task<BetfairServerResponse<AccountStatementReport>> GetAccountStatement(int? fromRecord = null, int? recordCount = null, TimeRange itemDateRange = null, IncludeItem? includeItem = null, Wallet? wallet = null);
        BetfairServerResponse<KeepAliveResponse> KeepAlive();
        Task<BetfairServerResponse<ClearedOrderSummaryReport>> ListClearedOrders(BetStatus betStatus, ISet<string> eventTypeIds = null, ISet<string> eventIds = null, ISet<string> marketIds = null, ISet<RunnerId> runnerIds = null, ISet<string> betIds = null, Side? side = null, TimeRange settledDateRange = null, GroupBy? groupBy = null, bool? includeItemDescription = null, int? fromRecord = null, int? recordCount = null);
        Task<BetfairServerResponse<List<CompetitionResult>>> ListCompetitions(MarketFilter marketFilter);
        Task<BetfairServerResponse<List<CountryCodeResult>>> ListCountries(MarketFilter marketFilter);
        Task<BetfairServerResponse<List<CurrencyRate>>> ListCurrencyRates(string fromCurrency);
        Task<BetfairServerResponse<CurrentOrderSummaryReport>> ListCurrentOrders(ISet<string> betIds = null, ISet<string> marketIds = null, OrderProjection? orderProjection = null, TimeRange placedDateRange = null, TimeRange dateRange = null, OrderBy? orderBy = null, SortDir? sortDir = null, int? fromRecord = null, int? recordCount = null);
        Task<BetfairServerResponse<List<EventResult>>> ListEvents(MarketFilter marketFilter);
        Task<BetfairServerResponse<List<EventTypeResult>>> ListEventTypes(MarketFilter marketFilter);
        Task<BetfairServerResponse<List<MarketBook>>> ListMarketBook(IEnumerable<string> marketIds, PriceProjection priceProjection = null, OrderProjection? orderProjection = null, MatchProjection? matchProjection = null);
        Task<BetfairServerResponse<List<MarketCatalogue>>> ListMarketCatalogue(MarketFilter marketFilter, ISet<MarketProjection> marketProjections = null, MarketSort? sort = null, int maxResult = 1);
        Task<BetfairServerResponse<List<MarketProfitAndLoss>>> ListMarketProfitAndLoss(ISet<string> marketIds, bool includeSettledBets, bool includeBsbBets, bool netOfCommission);
        Task<BetfairServerResponse<List<MarketTypeResult>>> ListMarketTypes(MarketFilter marketFilter);
        Task<BetfairServerResponse<List<TimeRangeResult>>> ListTimeRanges(MarketFilter marketFilter, TimeGranularity timeGranularity);
        Task<BetfairServerResponse<List<VenueResult>>> ListVenues(MarketFilter marketFilter);
        (string, bool) Login(string p12CertificateLocation, string p12CertificatePassword, string username, string password);
        Task<BetfairServerResponse<PlaceExecutionReport>> PlaceOrders(string marketId, IList<PlaceInstruction> placeInstructions, string customerRef = null, string customeStrategyReference = null);
        Task<BetfairServerResponse<ReplaceExecutionReport>> ReplaceOrders(string marketId, IList<ReplaceInstruction> instructions, string customerRef = null);
        Task<BetfairServerResponse<TransferResponse>> TransferFunds(Wallet from, Wallet to, double amount);
        Task<BetfairServerResponse<UpdateExecutionReport>> UpdateOrders(string marketId, IList<UpdateInstruction> instructions, string customerRef = null);
    }
}