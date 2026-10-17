namespace AsparkErp.Domain.Entities
{
    // MODÜL 98: Ana Veri Yönetimi
    public class MasterDataRecord : TenantEntity
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = "Draft";
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
        public string Currency { get; set; } = "TRY";
        public DateTime? EffectiveDate { get; set; }
        public Guid? RelatedEntityId { get; set; }
    }
}
