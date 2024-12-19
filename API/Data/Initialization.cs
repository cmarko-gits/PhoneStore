using API.Entitiees.Specification;
using API.Entities;

namespace API.Data
{
    public class Initialization
    {
        private readonly StoreContext _context;

        public Initialization(StoreContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    Name = "Samsung Galaxy S22",
                    OldPrice = 799,
                    Price = 699,
                    IsOnSale = false,
                    QuantityInStock = 50,
                    Specifications = new Specification
                    {
                        Brand = Brand.Samsung,
                        OperatingSystem = Os.Android,
                        CPU = "Exynos 2200",
                        ScreenSize = 6.1f,
                        ScreenType = "Dynamic AMOLED 2X",
                        RAM = 8,
                        InternalStorage = 128,
                        BatteryCapacity = 3700,
                        FastCharging = true,
                        FastChargingWatt = 25,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Apple iPhone 13",
                    OldPrice = 899,
                    Price = 799,
                    IsOnSale = true,
                    QuantityInStock = 80,
                    Specifications = new Specification
                    {
                        Brand = Brand.Apple,
                        OperatingSystem = Os.IOS,
                        CPU = "A15 Bionic",
                        ScreenSize = 6.1f,
                        ScreenType = "Super Retina XDR",
                        RAM = 4,
                        InternalStorage = 128,
                        BatteryCapacity = 3240,
                        FastCharging = true,
                        FastChargingWatt = 20,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Xiaomi 12 Pro",
                    OldPrice = 999,
                    Price = 899,
                    IsOnSale = false,
                    QuantityInStock = 70,
                    Specifications = new Specification
                    {
                        Brand = Brand.Xiaomi,
                        OperatingSystem = Os.Android,
                        CPU = "Snapdragon 8 Gen 1",
                        ScreenSize = 6.73f,
                        ScreenType = "AMOLED",
                        RAM = 12,
                        InternalStorage = 256,
                        BatteryCapacity = 4600,
                        FastCharging = true,
                        FastChargingWatt = 120,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Huawei P50 Pro",
                    OldPrice = 1099,
                    Price = 999,
                    IsOnSale = true,
                    QuantityInStock = 60,
                    Specifications = new Specification
                    {
                        Brand = Brand.Huawei,
                        OperatingSystem = Os.Android,
                        CPU = "Kirin 9000",
                        ScreenSize = 6.6f,
                        ScreenType = "OLED",
                        RAM = 8,
                        InternalStorage = 256,
                        BatteryCapacity = 4360,
                        FastCharging = true,
                        FastChargingWatt = 66,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Samsung Galaxy Z Flip 4",
                    OldPrice = 999,
                    Price = 899,
                    IsOnSale = true,
                    QuantityInStock = 50,
                    Specifications = new Specification
                    {
                        Brand = Brand.Samsung,
                        OperatingSystem = Os.Android,
                        CPU = "Snapdragon 8 Gen 1",
                        ScreenSize = 6.7f,
                        ScreenType = "Dynamic AMOLED 2X",
                        RAM = 8,
                        InternalStorage = 128,
                        BatteryCapacity = 3700,
                        FastCharging = true,
                        FastChargingWatt = 25,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Apple iPhone 14 Pro",
                    OldPrice = 1099,
                    Price = 999,
                    IsOnSale = false,
                    QuantityInStock = 75,
                    Specifications = new Specification
                    {
                        Brand = Brand.Apple,
                        OperatingSystem = Os.IOS,
                        CPU = "A16 Bionic",
                        ScreenSize = 6.1f,
                        ScreenType = "Super Retina XDR",
                        RAM = 6,
                        InternalStorage = 128,
                        BatteryCapacity = 3200,
                        FastCharging = true,
                        FastChargingWatt = 20,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Xiaomi Mi 11 Ultra",
                    OldPrice = 999,
                    Price = 899,
                    IsOnSale = true,
                    QuantityInStock = 80,
                    Specifications = new Specification
                    {
                        Brand = Brand.Xiaomi,
                        OperatingSystem = Os.Android,
                        CPU = "Snapdragon 888",
                        ScreenSize = 6.81f,
                        ScreenType = "AMOLED",
                        RAM = 12,
                        InternalStorage = 256,
                        BatteryCapacity = 5000,
                        FastCharging = true,
                        FastChargingWatt = 67,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Huawei Mate 40 Pro",
                    OldPrice = 1099,
                    Price = 999,
                    IsOnSale = false,
                    QuantityInStock = 60,
                    Specifications = new Specification
                    {
                        Brand = Brand.Huawei,
                        OperatingSystem = Os.Android,
                        CPU = "Kirin 9000",
                        ScreenSize = 6.76f,
                        ScreenType = "OLED",
                        RAM = 8,
                        InternalStorage = 256,
                        BatteryCapacity = 4400,
                        FastCharging = true,
                        FastChargingWatt = 66,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Samsung Galaxy Note 20 Ultra",
                    OldPrice = 1099,
                    Price = 999,
                    IsOnSale = true,
                    QuantityInStock = 50,
                    Specifications = new Specification
                    {
                        Brand = Brand.Samsung,
                        OperatingSystem = Os.Android,
                        CPU = "Exynos 990",
                        ScreenSize = 6.9f,
                        ScreenType = "Dynamic AMOLED 2X",
                        RAM = 12,
                        InternalStorage = 256,
                        BatteryCapacity = 4500,
                        FastCharging = true,
                        FastChargingWatt = 25,
                        WirelessCharging = true
                    }
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Apple iPhone SE (2022)",
                    OldPrice = 499,
                    Price = 399,
                    IsOnSale = false,
                    QuantityInStock = 100,
                    Specifications = new Specification
                    {
                        Brand = Brand.Apple,
                        OperatingSystem = Os.IOS,
                        CPU = "A15 Bionic",
                        ScreenSize = 4.7f,
                        ScreenType = "Retina HD",
                        RAM = 3,
                        InternalStorage = 64,
                        BatteryCapacity = 1821,
                        FastCharging = true,
                        FastChargingWatt = 18,
                        WirelessCharging = true
                    }
                },
                    new Product
{
    ProductId = 11,
    Name = "Samsung Galaxy S21",
    OldPrice = 799,
    Price = 699,
    IsOnSale = true,
    QuantityInStock = 150,
    Specifications = new Specification
    {
        Brand = Brand.Samsung,
        OperatingSystem = Os.Android,
        CPU = "Exynos 2100",
        ScreenSize = 6.2f,
        ScreenType = "Dynamic AMOLED 2X",
        RAM = 8,
        InternalStorage = 128,
        BatteryCapacity = 4000,
        FastCharging = true,
        FastChargingWatt = 25,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 12,
    Name = "Apple iPhone 13",
    OldPrice = 899,
    Price = 799,
    IsOnSale = false,
    QuantityInStock = 120,
    Specifications = new Specification
    {
        Brand = Brand.Apple,
        OperatingSystem = Os.IOS,
        CPU = "A15 Bionic",
        ScreenSize = 6.1f,
        ScreenType = "Super Retina XDR",
        RAM = 6,
        InternalStorage = 128,
        BatteryCapacity = 3227,
        FastCharging = true,
        FastChargingWatt = 20,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 13,
    Name = "Xiaomi Mi 11",
    OldPrice = 749,
    Price = 649,
    IsOnSale = true,
    QuantityInStock = 110,
    Specifications = new Specification
    {
        Brand = Brand.Xiaomi,
        OperatingSystem = Os.Android,
        CPU = "Snapdragon 888",
        ScreenSize = 6.81f,
        ScreenType = "AMOLED",
        RAM = 8,
        InternalStorage = 128,
        BatteryCapacity = 4600,
        FastCharging = true,
        FastChargingWatt = 55,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 14,
    Name = "Huawei P40 Pro",
    OldPrice = 899,
    Price = 799,
    IsOnSale = false,
    QuantityInStock = 70,
    Specifications = new Specification
    {
        Brand = Brand.Huawei,
        OperatingSystem = Os.Android,
        CPU = "Kirin 990 5G",
        ScreenSize = 6.58f,
        ScreenType = "OLED",
        RAM = 8,
        InternalStorage = 256,
        BatteryCapacity = 4200,
        FastCharging = true,
        FastChargingWatt = 40,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 15,
    Name = "Samsung Galaxy A72",
    OldPrice = 499,
    Price = 429,
    IsOnSale = true,
    QuantityInStock = 130,
    Specifications = new Specification
    {
        Brand = Brand.Samsung,
        OperatingSystem = Os.Android,
        CPU = "Snapdragon 720G",
        ScreenSize = 6.7f,
        ScreenType = "Super AMOLED",
        RAM = 6,
        InternalStorage = 128,
        BatteryCapacity = 5000,
        FastCharging = true,
        FastChargingWatt = 25,
        WirelessCharging = false
    }
},
new Product
{
    ProductId = 16,
    Name = "Apple iPhone SE (2020)",
    OldPrice = 399,
    Price = 349,
    IsOnSale = false,
    QuantityInStock = 90,
    Specifications = new Specification
    {
        Brand = Brand.Apple,
        OperatingSystem = Os.IOS,
        CPU = "A13 Bionic",
        ScreenSize = 4.7f,
        ScreenType = "Retina HD",
        RAM = 3,
        InternalStorage = 64,
        BatteryCapacity = 1821,
        FastCharging = true,
        FastChargingWatt = 18,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 17,
    Name = "Xiaomi Redmi Note 10 Pro",
    OldPrice = 279,
    Price = 239,
    IsOnSale = true,
    QuantityInStock = 100,
    Specifications = new Specification
    {
        Brand = Brand.Xiaomi,
        OperatingSystem = Os.Android,
        CPU = "Snapdragon 732G",
        ScreenSize = 6.67f,
        ScreenType = "AMOLED",
        RAM = 6,
        InternalStorage = 64,
        BatteryCapacity = 5020,
        FastCharging = true,
        FastChargingWatt = 33,
        WirelessCharging = false
    }
},
new Product
{
    ProductId = 18,
    Name = "Huawei Mate 40 Pro",
    OldPrice = 1099,
    Price = 999,
    IsOnSale = false,
    QuantityInStock = 50,
    Specifications = new Specification
    {
        Brand = Brand.Huawei,
        OperatingSystem = Os.Android,
        CPU = "Kirin 9000",
        ScreenSize = 6.76f,
        ScreenType = "OLED",
        RAM = 8,
        InternalStorage = 256,
        BatteryCapacity = 4400,
        FastCharging = true,
        FastChargingWatt = 66,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 19,
    Name = "Apple iPhone 12 Pro Max",
    OldPrice = 1099,
    Price = 999,
    IsOnSale = false,
    QuantityInStock = 40,
    Specifications = new Specification
    {
        Brand = Brand.Apple,
        OperatingSystem = Os.IOS,
        CPU = "A14 Bionic",
        ScreenSize = 6.7f,
        ScreenType = "Super Retina XDR",
        RAM = 6,
        InternalStorage = 128,
        BatteryCapacity = 3687,
        FastCharging = true,
        FastChargingWatt = 20,
        WirelessCharging = true
    }
},
new Product
{
    ProductId = 20,
    Name = "Xiaomi Poco X3 Pro",
    OldPrice = 299,
    Price = 259,
    IsOnSale = true,
    QuantityInStock = 150,
    Specifications = new Specification
    {
        Brand = Brand.Xiaomi,
        OperatingSystem = Os.Android,
        CPU = "Snapdragon 860",
        ScreenSize = 6.67f,
        ScreenType = "IPS LCD",
        RAM = 6,
        InternalStorage = 128,
        BatteryCapacity = 5160,
        FastCharging = true,
        FastChargingWatt = 33,
        WirelessCharging = false
    }
}

            };

            _context.Products.AddRange(products);
            _context.SaveChanges();
        }
    }
}  