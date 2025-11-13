namespace OrderingSystem.Model
{
    public class Supplier
    {
        public int SupplierId { get; protected set; }
        public string SupplierName { get; protected set; }
        public Supplier(int supplierId, string supplierName)
        {
            SupplierId = supplierId;
            SupplierName = supplierName;
        }
        public Supplier(string supplierName)
        {
            SupplierName = supplierName;
        }

    }
}
