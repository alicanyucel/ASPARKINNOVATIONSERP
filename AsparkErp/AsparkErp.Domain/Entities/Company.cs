namespace AsparkErp.Domain.Entities
{
    // DOMAIN ENTITY SINIFLARI: 100 MODÜL / 200 ENTITY

    // MODÜL 1: Şirket Yönetimi
    public class Company : TenantEntity
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
