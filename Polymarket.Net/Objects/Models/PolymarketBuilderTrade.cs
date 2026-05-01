using System;
using System.Text.Json.Serialization;
using Polymarket.Net.Enums;

namespace Polymarket.Net.Objects.Models;

/// <summary>
/// 
/// </summary>
public record PolymarketBuilderTrade
{
    /// <summary>
    /// ["<c>id</c>"] Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>tradeType</c>"] Role
    /// </summary>
    [JsonPropertyName("tradeType")]
    public TradeRole Role { get; set; }
    /// <summary>
    /// ["<c>takerOrderHash</c>"] Taker order hash
    /// </summary>
    [JsonPropertyName("takerOrderHash")]
    public string TakerOrderHash { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>builder</c>"] Builder
    /// </summary>
    [JsonPropertyName("builder")]
    public string? Builder { get; set; }
    /// <summary>
    /// ["<c>market</c>"] Market id
    /// </summary>
    [JsonPropertyName("market")]
    public string MarketId { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>assetId</c>"] Asset id
    /// </summary>
    [JsonPropertyName("assetId")]
    public string AssetId { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>side</c>"] Side
    /// </summary>
    [JsonPropertyName("side")]
    public OrderSide Side { get; set; }
    /// <summary>
    /// ["<c>size</c>"] Quantity
    /// </summary>
    [JsonPropertyName("size")]
    public decimal Quantity { get; set; }
    /// <summary>
    /// ["<c>sizeUsdc</c>"] Quantity usdc
    /// </summary>
    [JsonPropertyName("sizeUsdc")]
    public decimal QuantityUsdc { get; set; }
    /// <summary>
    /// ["<c>price</c>"] Price
    /// </summary>
    [JsonPropertyName("price")]
    public decimal Price { get; set; }
    /// <summary>
    /// ["<c>status</c>"] Status
    /// </summary>
    [JsonPropertyName("status")]
    public TradeStatus Status { get; set; }
    /// <summary>
    /// ["<c>outcome</c>"] Outcome
    /// </summary>
    [JsonPropertyName("outcome")]
    public string Outcome { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>outcomeIndex</c>"] Outcome index
    /// </summary>
    [JsonPropertyName("outcomeIndex")]
    public int OutcomeIndex { get; set; }
    /// <summary>
    /// ["<c>owner</c>"] Owner
    /// </summary>
    [JsonPropertyName("owner")]
    public string Owner { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>maker</c>"] Maker
    /// </summary>
    [JsonPropertyName("maker")]
    public string Maker { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>transactionHash</c>"] Transaction hash
    /// </summary>
    [JsonPropertyName("transactionHash")]
    public string TransactionHash { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>matchTime</c>"] Match time
    /// </summary>
    [JsonPropertyName("matchTime")]
    public DateTime MatchTime { get; set; }
    /// <summary>
    /// ["<c>bucketIndex</c>"] Bucket index
    /// </summary>
    [JsonPropertyName("bucketIndex")]
    public int BucketIndex { get; set; }
    /// <summary>
    /// ["<c>fee</c>"] Fee
    /// </summary>
    [JsonPropertyName("fee")]
    public decimal Fee { get; set; }
    /// <summary>
    /// ["<c>feeUsdc</c>"] Fee usdc
    /// </summary>
    [JsonPropertyName("feeUsdc")]
    public decimal FeeUsdc { get; set; }
    /// <summary>
    /// ["<c>builderFee</c>"] Builder fee
    /// </summary>
    [JsonPropertyName("builderFee")]
    public decimal BuilderFee { get; set; }
    /// <summary>
    /// ["<c>builderCode</c>"] Builder code
    /// </summary>
    [JsonPropertyName("builderCode")]
    public string BuilderCode { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>createdAt</c>"] Created at
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// ["<c>updatedAt</c>"] Updated at
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}

