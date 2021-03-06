﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DicBLL
    {
        public string defaultPass()
        {
            return "vanlang";
        }
        public string errorloginMessage(string error)
        {
            switch (error)
            {
                case "chua active":
                    return "Tài khoản của bạn chưa được kích hoạt. \n Vui lòng liên hệ người quản trị để kích hoạt";
                case "sai pass":
                    return "Bạn đã nhập sai mật khẩu. \n Vui lòng kiểm tra lại.";
                case "sai user":
                    return "Bạn đã nhập sai tên đăng nhập hoặc tài khoản của bạn không tồn tại trong hệ thống. \n Vui lòng kiểm tra lại";
                case "sai email":
                    return "Bạn đã nhập sai tên đăng nhập. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string successResetMessage()
        {
            return "Đặt lại mật khẩu thành công.\n Mật khẩu mặc định là vanlang";
        }
        public string errorResetMessage(string error)
        {
            switch (error)
            {
                case "sai user":
                    return "Bạn đã nhập sai tên đăng nhập hoặc tài khoản của bạn không tồn tại trong hệ thống. \n Vui lòng kiểm tra lại";
                case "sai email":
                    return "Bạn đã nhập sai tên đăng nhập. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }
        public string errorAccountMessage(string error)
        {
            switch (error)
            {
                case "sai email":
                    return "Email không hợp lệ. \n Vui lòng kiểm tra lại";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";
            }
        }

        public string successAccountMessage(string sc)
        {
            switch(sc)
            {
                case "add":
                    return "Thêm tài khoản thành công.";
                case "edit":
                    return "Sửa tài khoản thành công.";
                case "delete":
                    return "Xóa tài khoản thành công.";
                case "else":
                    return "Lỗi kết nối.\n Vui lòng kiểm tra lại đường truyền mạng.";
                default:
                    return "No exception";

            }
        }

        public string errorChangeMessage(string er)
        {
            switch(er)
            {
                case "samepass":
                    return "Mật khẩu mới phải khác mật khẩu cũ.\n Vui lòng kiểm tra lại.";
                case "samename":
                    return "Họ và tên không thay đổi.";
                case "confirm":
                    return "Mật khẩu mới và Mật khẩu xác nhận không khớp.\n Vui lòng kiểm tra lại";
                case "wrongpass":
                    return "Mật khẩu cũ không đúng. \n Vui lòng kiểm tra lại.";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string successChangeMessage(string sc)
        {
            switch(sc)
            {
                case "changepass":
                    return "Thay đổi mật khẩu thành công";
                case "changename":
                    return "Thay đổi tên thành công";
                case "changeinfo":
                    return "Thay đổi thông tin cá nhân thành công";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string errorCreateProgram(string er)
        {
            switch(er)
            {
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }
        public string successCreateProgram(string sc)
        {
            switch (sc)
            {
                case "createprogram":
                    return "Tạo chương trình đào tạo mới thành công";
                case "else":
                    return "Lỗi kết nối.\v Vui lòng kiểm tra lại";
                default:
                    return "No exception";
            }
        }

    }
}
