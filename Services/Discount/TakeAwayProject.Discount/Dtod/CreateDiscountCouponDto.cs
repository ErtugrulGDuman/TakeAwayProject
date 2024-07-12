namespace TakeAwayProject.Discount.Dtod
{
    public class CreateDiscountCouponDto
    {
        public string Code { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
    }
}
