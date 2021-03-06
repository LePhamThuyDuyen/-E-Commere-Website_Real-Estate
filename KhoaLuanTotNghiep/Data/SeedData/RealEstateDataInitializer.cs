using KhoaLuanTotNghiep_BackEnd.Enum;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Data.SeedData
{
    public static class RealEstateDataInitializer
    {
        public static void SeedRealEstateData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    RealEstateID = Guid.NewGuid().ToString(),
                    UserID = "98f56474-6dee-4c27-96c0-73cc20149b89",
                    AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                    CategoryID = "1",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Approve = false,
                    Status = Convert.ToInt32(StateApprove.Available),
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = Guid.NewGuid().ToString(),
                    UserID = "98f56474-6dee-4c27-96c0-73cc20149b89",
                    AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                    CategoryID = "1",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Approve = false,
                    Status = Convert.ToInt32(StateApprove.Available),
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = Guid.NewGuid().ToString(),
                    UserID = "98f56474-6dee-4c27-96c0-73cc20149b89",
                    AdminID = "8553cf57-afbc-4940-8289-210fdd44de89",
                    CategoryID = "2",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Approve = false,
                    Status = Convert.ToInt32(StateApprove.Available),
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                }
                //new RealEstate
                //{
                //    RealEstateID = "4",
                //    UserID = "6b9d189f-011a-438b-9477-1b01e78d160d",
                //    CategoryID = "2",
                //    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                //    Price = "19 tỷ",
                //    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png",
                //    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                //    Acgreage = "95",
                //    Approve = false,
                //    Status = false,
                //    Location = "50 Lê Lợi",
                //    CreateTime = DateTime.Now,
                //    UpdateTime = DateTime.Now,
                //},
                //new RealEstate
                //{
                //    RealEstateID = "5",
                //    UserID = "6b9d189f-011a-438b-9477-1b01e78d160d",
                //    CategoryID = "3",
                //    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                //    Price = "19 tỷ",
                //    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg",
                //    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                //    Acgreage = "95",
                //    Approve = false,
                //    Status = false,
                //    Location = "50 Lê Lợi",
                //    CreateTime = DateTime.Now,
                //    UpdateTime = DateTime.Now,
                //},
                //new RealEstate
                //{
                //    RealEstateID = "6",
                //    UserID = "6b9d189f-011a-438b-9477-1b01e78d160d",
                //    CategoryID = "3",
                //    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                //    Price = "19 tỷ",
                //    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg",
                //    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                //    Acgreage = "95",
                //    Approve = false,
                //    Status = false,
                //    Location = "50 Lê Lợi",
                //    CreateTime = DateTime.Now,
                //    UpdateTime = DateTime.Now,
                //}
            );
        }
    }
}
