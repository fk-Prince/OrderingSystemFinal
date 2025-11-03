using System;
using System.Collections.Generic;
using OrderingSystem.Model;
using OrderingSystem.Repository;

namespace OrderingSystem.Services
{
    public class KioskMenuServices
    {
        private IKioskMenuRepository menuRepository;
        public KioskMenuServices(IKioskMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        public List<MenuModel> getMenu()
        {
            return menuRepository.getMenu();
        }

        public int getMaxOrderRealTime(int menuDetailId, List<OrderItemModel> orderList)
        {
            return menuRepository.getMaxOrderRealTime(menuDetailId, orderList);
        }

        public List<MenuModel> getDetails(MenuModel menu)
        {
            return menuRepository.getDetails(menu);
        }

        public bool isMenuPackage(MenuModel menu)
        {
            return menuRepository.isMenuPackage(menu);
        }

        public List<MenuModel> getFrequentlyOrderedTogether(MenuModel menus)
        {
            return menuRepository.getFrequentlyOrderedTogether(menus);
        }

        public List<MenuModel> getIncludedMenu(MenuModel menu)
        {
            return menuRepository.getIncludedMenu(menu);
        }

        public double getNewPackagePrice(int menuDetailId, List<MenuModel> includedMenu)
        {
            return menuRepository.getNewPackagePrice(menuDetailId, includedMenu);
        }

        public List<MenuModel> getDetailsByPackage(MenuModel menuDetail)
        {
            List<MenuModel> l = menuRepository.getDetailsByPackage(menuDetail);

            List<MenuModel> newList = new List<MenuModel>();

            foreach (var i in l)
            {
                var menuPackage = MenuPackageModel.Builder()
                                    .WithMenuId(i.MenuId)
                                    .WithMenuDetailId(i.MenuDetailId)
                                    .WithPrice(i.MenuPrice)
                                    .WithMaxOrder(i.MaxOrder)
                                    .WithFlavorName(i.FlavorName)
                                    .WithDiscount(menuDetail.Discount)
                                    .WithSizeName(i.SizeName)
                                    .Build();

                newList.Add(menuPackage);
            }

            return newList;
        }

        internal List<MenuModel> getMenuDetail()
        {
            throw new NotImplementedException();
        }
    }
}
