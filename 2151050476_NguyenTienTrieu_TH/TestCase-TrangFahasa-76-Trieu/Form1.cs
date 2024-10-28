using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TestCase_TrangFahasa_76_Trieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            //comboBox2 của đăng Nhập
            cbBDangNhap.Items.Add("Test Case 1: Đăng Nhập Thành Công");
            cbBDangNhap.Items.Add("Test Case 2: Đăng Nhập Nhập Sai Tài Khoản");
            cbBDangNhap.Items.Add("Test Case 3: Đăng Nhập Nhập Sai Mật Khẩu");
            cbBDangNhap.Items.Add("Test Case 4: Đăng Nhập Nhập Sai Tài Khoản Và Mật Khẩu");




            //comboBox3 của TimKiemSanPham
            cbBTimKiemSanPham.Items.Add("Test Case 1: Nhập Tên sản phẩm đầy đủ");
            cbBTimKiemSanPham.Items.Add("Test Case 2: Nhập một nửa tên sản phẩm");
            cbBTimKiemSanPham.Items.Add("Test Case 3: Nhập tên sản phẩm không tồn tại");
            cbBTimKiemSanPham.Items.Add("Test Case 4: Nhập tên sản phẩm với ký tự đặc biệt");
            cbBTimKiemSanPham.Items.Add("Test Case 5: Nhập thừa tên sản phẩm");
            cbBTimKiemSanPham.Items.Add("Test Case 6: Để ô tìm kiếm trống và tìm kiếm");
            //phần mã
            cbBTimKiemSanPham.Items.Add("Test Case 7: Nhập mã sản phẩm đầy đủ");
            cbBTimKiemSanPham.Items.Add("Test Case 8: Nhập một nửa mã sản phẩm");
            cbBTimKiemSanPham.Items.Add("Test Case 9: Nhập mã sản phẩm không tồn tại");
            cbBTimKiemSanPham.Items.Add("Test Case 10: Nhập mã sản phẩm với ký tự đặc biệt");


            //Muahang
            cbBMuaHang.Items.Add("Test Case 1: Mua Hàng");
            cbBMuaHang.Items.Add("Test Case 2: Hủy Đơn Đặt Hàng");

            //Giohang
            cbBGioHang.Items.Add("Test Case 1: Vào xem Giỏ hàng");
            cbBGioHang.Items.Add("Test Case 2: Thêm sách vào giỏ hàng");
            cbBGioHang.Items.Add("Test Case 3: Tăng Số Lượng sản phẩm trong giỏ hàng");
            cbBGioHang.Items.Add("Test Case 4: Xóa Sản Phẩm khỏi giỏ hàng");


        }

   

        //DangNhap
        private void DangNhap_Click(object sender, EventArgs e)
        {

            if (cbBDangNhap.SelectedItem != null)
            {
                string selectedAction = cbBDangNhap.SelectedItem.ToString();

                switch (selectedAction)
                {
                    case "Test Case 1: Đăng Nhập Thành Công":
                        nDangNhap("0979904617", "trieu0975579487");
                        break;
                    case "Test Case 2: Đăng Nhập Nhập Sai Tài Khoản":
                        nDangNhap("09075579486", "trieu0975579487");
                        break;
                    case "Test Case 3: Đăng Nhập Nhập Sai Mật Khẩu":
                        nDangNhap("0975579487", "trieu0975179487");
                        break;
                    case "Test Case 4: Đăng Nhập Nhập Sai Tài Khoản Và Mật Khẩu":
                        nDangNhap("0975679487", "trieu0975179487");
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn một mục hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
            }
        }

        private void nDangNhap(string username, string password)
        {
            ChromeDriverService chrome_76_Trieu = ChromeDriverService.CreateDefaultService();
            chrome_76_Trieu.HideCommandPromptWindow = true;
            IWebDriver driver_76_Trieu = new ChromeDriver(chrome_76_Trieu);

            driver_76_Trieu.Navigate().GoToUrl("https://www.fahasa.com/");
            Thread.Sleep(2000);

            driver_76_Trieu.FindElement(By.CssSelector("#fhs_top_account_hover > a > div > div.icon_account_gray")).Click();
            Thread.Sleep(2000);

            driver_76_Trieu.FindElement(By.Id("login_username")).SendKeys(username);
            Thread.Sleep(2000);

            driver_76_Trieu.FindElement(By.Id("login_password")).SendKeys(password);
            Thread.Sleep(2000);

            driver_76_Trieu.FindElement(By.CssSelector("#wrapper > div.page > div.main-container.col1-layout.no-margin-top > div > div.col-main > div > div > " +
                "div.fhs_login_form > div > div > div.popup-login-content > form > div:nth-child(4) > div > button.fhs-btn-login > span")).Click();
            Thread.Sleep(2000);
        }






        //TimKiemSanPham
        private void TimKiemSanPham_Click(object sender, EventArgs e)
        {
            if (cbBTimKiemSanPham.SelectedItem != null)
            {
                string selectedAction = cbBTimKiemSanPham.SelectedItem.ToString();

                switch (selectedAction)
                {
                    case "Test Case 1: Nhập Tên sản phẩm đầy đủ":
                        nTimKiemSanPham("Sapiens Lược Sử Loài Người");
                        break;
                    case "Test Case 2: Nhập một nửa tên sản phẩm":
                        nTimKiemSanPham("Sapiens Lược");
                        break;
                    case "Test Case 3: Nhập tên sản phẩm không tồn tại":
                        nTimKiemSanPham("Cơ sở lập trình");
                        break;
                    case "Test Case 4: Nhập tên sản phẩm với ký tự đặc biệt":
                        nTimKiemSanPham("Sa#piens Lư#ợc Sử Lo#ài Người");
                        break;
                    case "Test Case 5: Nhập thừa tên sản phẩm":
                        nTimKiemSanPham("Sapiens Lược Sử Loài Người Thật thà có thật không");
                        break;
                    case "Test Case 6: Để ô tìm kiếm trống và tìm kiếm":
                        nTimKiemSanPham("");
                        break;
                    case "Test Case 7: Nhập mã sản phẩm đầy đủ":
                        nTimKiemSanPham("8935270703554");
                        break;
                    case "Test Case 8: Nhập một nửa mã sản phẩm":
                        nTimKiemSanPham("8935270");
                        break;
                    case "Test Case 9: Nhập mã sản phẩm không tồn tại":
                        nTimKiemSanPham("7623762732637");
                        break;
                    case "Test Case 10: Nhập mã sản phẩm với ký tự đặc biệt":
                        nTimKiemSanPham("8#935270#703554");
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn một mục hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
            }
        }


        // Phương thức dùng chung để tìm kiếm sản phẩm
        private void nTimKiemSanPham(string tuKhoa)
        {
            ChromeDriverService chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chromeService);
            try
            {
                driver.Navigate().GoToUrl("https://www.fahasa.com/");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("search_desktop")).SendKeys(tuKhoa);
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#search_mini_form_desktop > div > div > span > span")).Click();
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + e.Message);
            }
            finally
            {
                // Đóng trình duyệt và giải phóng tài nguyên
                driver.Quit();
            }
        }


        //WebDriver và đăng nhập
        private IWebDriver InitializeDriver()
        {
            ChromeDriverService chromeService = ChromeDriverService.CreateDefaultService();
            chromeService.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chromeService);
            driver.Navigate().GoToUrl("https://www.fahasa.com/");
            return driver;
        }

        private void mDangNhap(IWebDriver driver)
        {
            driver.FindElement(By.CssSelector("#fhs_top_account_hover > a > div > div.icon_account_gray")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Id("login_username")).SendKeys("0979904617");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login_password")).SendKeys("trieu0975579487");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#wrapper > div.page > div.main-container.col1-layout.no-margin-top > div > div.col-main > div > div > " +
                "div.fhs_login_form > div > div > div.popup-login-content > form > div:nth-child(4) > div > button.fhs-btn-login > span")).Click();
            Thread.Sleep(20000);
        }



        //Muahang
        private void MuaHang_Click(object sender, EventArgs e)
        {
            if (cbBMuaHang.SelectedItem != null)
            {
                string selectedAction = cbBMuaHang.SelectedItem.ToString();

                switch (selectedAction)
                {
                    case "Test Case 1: Mua Hàng":
                        tc_1_MuaHang_76_Trieu();
                        break;
                    case "Test Case 2: Hủy Đơn Đặt Hàng":
                        tc_2_HuyDonDatHang_76_Trieu();
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn một mục hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
            }
        }


        private void tc_1_MuaHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Mua hàng
                driver.FindElement(By.Id("search_desktop")).SendKeys("8931805889076");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector("#search_mini_form_desktop > div > div > span > span")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.ClassName("lazyloaded")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#product_view_kasitoo > div > div.product-essential-media-parent > div > div.product_view_media_fk_addtocart >" +
                    " div.product_view_add_box > button.btn-buy-now > span")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("checkbox-product-589296")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#form-cart > div > div.col-sm-4.hidden-max-width-992 > div > div > div.block-total-cart >" +
                    " div.checkout-type-button-cart > div > button > span > span")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#wrapper > div.page > div.main-container.col1-layout.no-margin-top > div > div.col-main > div > div > div:nth-child(25) " +
                    "> div.fhs_checkout_block_content > div.fhs-bsidebar > div > div > div.fhs_checkout_bottom > div:nth-child(3) > div > button > span")).Click();
                Thread.Sleep(10000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }

        private void tc_2_HuyDonDatHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Vào mã đơn hàng
                driver.FindElement(By.CssSelector("#wrapper > div.page > div.main-container.col2-left-layout.no-margin-top > div > div.container > div > div > " +
                    "div.col-left.sidebar.col-lg-3.col-md-3.col-sm-12.col-xs-12 > div.block.block-account > div.block-content > ul > li:nth-child(4) > a")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.Id("cancel-order-103560750")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.CssSelector("#reason-1 > div > div")).Click();
                Thread.Sleep(3000);
                driver.FindElement(By.Id("confirm-103560750")).Click();
                Thread.Sleep(10000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + e.Message);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }


        //GioHang
        private void GioHang_Click(object sender, EventArgs e)
        {
            if (cbBGioHang.SelectedItem != null)
            {
                string selectedAction = cbBGioHang.SelectedItem.ToString();

                switch (selectedAction)
                {
                    case "Test Case 1: Vào xem Giỏ hàng":
                        tc_1_VaoXemGioHang_76_Trieu();
                        break;
                    case "Test Case 2: Thêm sách vào giỏ hàng":
                        tc_2_ThemSanPhamVaoGioHang_76_Trieu();
                        break;
                    case "Test Case 3: Tăng Số Lượng sản phẩm trong giỏ hàng":
                        tc_3_TangSoLuongSanPhamTrongGioHang_76_Trieu();
                        break;
                    case "Test Case 4: Xóa Sản Phẩm khỏi giỏ hàng":
                        tc_4_XoaSanPhamTrongGioHang_76_Trieu();
                        break;
                    default:
                        MessageBox.Show("Vui lòng chọn một mục hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục từ ComboBox.");
            }
        }


        private void tc_1_VaoXemGioHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Vào giỏ hàng
                driver.FindElement(By.CssSelector("#header > div.fhs_header_desktop > div.container > div > div.fhs_center_space >" +
                    " div.cart-top.no_cover.fhs_dropdown_hover > div > a > div > div.fhs_center_center > div")).Click();
                Thread.Sleep(10000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }

        private void tc_2_ThemSanPhamVaoGioHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Thêm sản phẩm vào giỏ hàng
                driver.FindElement(By.Id("search_desktop")).SendKeys("8938507004295");
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector("#search_mini_form_desktop > div > div > span > span")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.ClassName("lazyloaded")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#product_view_kasitoo > div > div.product-essential-media-parent > div >" +
                    " div.product_view_media_fk_addtocart > div.product_view_add_box > button.btn-cart-to-cart > span:nth-child(2)")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#header > div.fhs_header_desktop > div.container > div > div.fhs_center_space >" +
                    " div.cart-top.no_cover.fhs_dropdown_hover > div > a > div > div.fhs_center_center > div")).Click();
                Thread.Sleep(10000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }

        private void tc_3_TangSoLuongSanPhamTrongGioHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Vào giỏ hàng
                driver.FindElement(By.CssSelector("#header > div.fhs_header_desktop > div.container > div > div.fhs_center_space " +
                    "> div.cart-top.no_cover.fhs_dropdown_hover > div > a > div > div.fhs_center_center > div")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#form-cart > div > div.col-sm-8.col-xs-12 > div > div.product-cart-left > div.item-product-cart >" +
                    " div.group-product-info > div.number-product-cart > div.product-view-quantity-box > div.product-view-quantity-box-block > a.btn-add-qty > img")).Click();
                Thread.Sleep(10000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }

        private void tc_4_XoaSanPhamTrongGioHang_76_Trieu()
        {
            IWebDriver driver = InitializeDriver();
            try
            {
                mDangNhap(driver);

                // Vào giỏ hàng xóa sản phẩm
                driver.FindElement(By.CssSelector("#header > div.fhs_header_desktop > div.container > div > " +
                    "div.fhs_center_space > div.cart-top.no_cover.fhs_dropdown_hover > div > a > div > div.fhs_center_center > div")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector("#form-cart > div > div.col-sm-8.col-xs-12 > div > " +
                    "div.product-cart-left > div.item-product-cart > div.div-of-btn-remove-cart > a > i")).Click();
                Thread.Sleep(2000);
            }
            finally
            {
                // Đóng trình duyệt
                driver.Quit();
            }
        }








    }
}
