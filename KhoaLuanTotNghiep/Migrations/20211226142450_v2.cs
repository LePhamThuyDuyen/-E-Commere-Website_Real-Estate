using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "realEstates",
                columns: new[] { "RealEstateID", "Acgreage", "AdminID", "Approve", "CategoryID", "CreateTime", "Description", "Image", "Location", "Price", "ReportID", "Status", "Title", "UpdateTime", "UserID" },
                values: new object[] { "fd1781db-344d-4a9d-adef-abaf4d9bca6e", "95", "8553cf57-afbc-4940-8289-210fdd44de89", false, "1", new DateTime(2021, 12, 26, 21, 24, 49, 700, DateTimeKind.Local).AddTicks(6803), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png", "50 Lê Lợi", "19 tỷ", null, 0, "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2454), "98f56474-6dee-4c27-96c0-73cc20149b89" });

            migrationBuilder.InsertData(
                table: "realEstates",
                columns: new[] { "RealEstateID", "Acgreage", "AdminID", "Approve", "CategoryID", "CreateTime", "Description", "Image", "Location", "Price", "ReportID", "Status", "Title", "UpdateTime", "UserID" },
                values: new object[] { "c63f7e1e-2178-4f56-9774-8c11bde5bfab", "95", "8553cf57-afbc-4940-8289-210fdd44de89", false, "1", new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2920), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png", "50 Lê Lợi", "19 tỷ", null, 0, "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2924), "98f56474-6dee-4c27-96c0-73cc20149b89" });

            migrationBuilder.InsertData(
                table: "realEstates",
                columns: new[] { "RealEstateID", "Acgreage", "AdminID", "Approve", "CategoryID", "CreateTime", "Description", "Image", "Location", "Price", "ReportID", "Status", "Title", "UpdateTime", "UserID" },
                values: new object[] { "40e9efbf-0437-4e15-95fc-82ee37208ebb", "95", "8553cf57-afbc-4940-8289-210fdd44de89", false, "2", new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2933), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png", "50 Lê Lợi", "19 tỷ", null, 0, "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 12, 26, 21, 24, 49, 701, DateTimeKind.Local).AddTicks(2934), "98f56474-6dee-4c27-96c0-73cc20149b89" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "40e9efbf-0437-4e15-95fc-82ee37208ebb");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "c63f7e1e-2178-4f56-9774-8c11bde5bfab");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "fd1781db-344d-4a9d-adef-abaf4d9bca6e");
        }
    }
}
