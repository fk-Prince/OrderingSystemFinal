using System;

namespace OrderingSystem.Model
{
    public enum CouponType
    {
        PERCENTAGE,
        FIXED
    }
    public class CouponModel
    {
        public string CouponCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public double CouponRate { get; set; }
        public double CouponMin { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int NumberOfTimes { get; set; }
        public string type { get; set; }

        public CouponModel(double couponRate, string type)
        {
            this.CouponRate = couponRate;
            this.type = type;
        }
        public CouponModel(string couponCode, string status, double couponRate, DateTime expiryDate, string description, string type, double min)
        {
            this.CouponCode = couponCode;
            this.Status = status;
            this.CouponRate = CouponRate;
            this.ExpiryDate = expiryDate;
            this.Description = description;
            this.type = type;
            this.CouponMin = min;
        }
        public CouponModel(double couponRate, DateTime expiryDate, string description, int numberOfTimes, string type, double min)
        {
            this.CouponRate = CouponRate;
            this.ExpiryDate = expiryDate;
            this.Description = description;
            this.NumberOfTimes = numberOfTimes;
            this.type = type;
            this.CouponMin = min;
        }
        public CouponType getType()
        {
            return type.ToUpper() == "FIXED" ? CouponType.FIXED : CouponType.PERCENTAGE;
        }

        public double calculate(double total)
        {
            return getType() == CouponType.FIXED ? total - CouponRate : total - (total * CouponRate);
        }
        public double getCoupon(double total)
        {
            return getType() == CouponType.FIXED ? CouponRate : total * CouponRate;
        }
        public double calculateX()
        {
            return getType() == CouponType.FIXED ? CouponRate : CouponRate * 100;
        }
    }
}
