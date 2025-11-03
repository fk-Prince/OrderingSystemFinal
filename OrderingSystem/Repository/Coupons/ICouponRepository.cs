using System.Collections.Generic;
using System.Data;
using OrderingSystem.Model;

namespace OrderingSystem.Repository
{
    public interface ICouponRepository
    {

        CouponModel getCoupon(string code);
        List<CouponModel> getAllCoupon();
        DataView generateCoupon(CouponModel co);
    }
}
