using System.Collections.Generic;
using OrderingSystem.Model;

namespace OrderingSystem.Repository
{
    public interface IKioskMenuRepository
    {
        List<MenuModel> getMenu();
        List<MenuModel> getDetails(MenuModel menu);
        List<MenuModel> getDetailsByPackage(MenuModel menu);
        List<MenuModel> getFrequentlyOrderedTogether(MenuModel menu);
        List<MenuModel> getIncludedMenu(MenuModel menu);
        bool isMenuPackage(MenuModel menu);
        int getMaxOrderRealTime(int menuDetailId, List<OrderItemModel> orderList);
        int getMaxOrderRealTime2(int menu_id, List<OrderItemModel> orderList);
        double getNewPackagePrice(int menuid, List<MenuModel> selectedMenus);
    }
}
