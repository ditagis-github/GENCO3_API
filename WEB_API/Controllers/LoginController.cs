﻿using System;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using DataProvider;
using DataProvider.EF;
using WebAPI.Models;
using DataProvider.SystemManagement;

namespace Web_API.Controllers
{
    [RoutePrefix("api/Login")]
    public class LoginController : ApiController
    {
        private AccountDB provider = new AccountDB();

        //public HttpResponseMessage Get(string Username, string Password)
        //{
        //    return this.Authenticate(new LoginRequest
        //    {
        //        Username = Username,
        //        Password = Password
        //    });
        //}

        [HttpGet]
        [Route("AuthSession/{sessionID}")]
        public HttpResponseMessage AuthSession(string sessionID)
        {
            try
            {
                var user = this.provider.CheckSession(sessionID);
                if (user != null)
                {
                    var tokenValidator = new TokenValidationHandler();
                    string token = tokenValidator.CreateToken(user.Username);
                    var loggerDB = new LoggerCapabilityDB();
                    loggerDB.Create(new SYS_Logger_Capability
                    {
                        TacVu = "Truy cập Quản lý tài khoản",
                        ThoiGian = DateTime.Now,
                        Username = user.Username
                    });
                    //return the token
                    return Request.CreateResponse(HttpStatusCode.OK, token);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Tài khoản hoặc mật khẩu không đúng");
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e.InnerException);
            }
        }

        [HttpPost]
        public HttpResponseMessage Authenticate([FromBody] LoginRequest login)
        {
            var loginResponse = new LoginResponse { };
            SYS_Account loginRequest = new SYS_Account
            {
                Username = login.Username.ToLower(),
                Password = login.Password
            };

            SYS_Account dbAccount = null;

            if (login != null)
            {
                try
                {
                    dbAccount = provider.IsValid(loginRequest);
                }
                catch (Exception e)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
                }
            }

            // if credentials are valid
            if (dbAccount != null)
            {
                var tokenValidator = new TokenValidationHandler();
                string token = tokenValidator.CreateToken(dbAccount.Username);
                var loggerDB = new LoggerCapabilityDB();

                loggerDB.Create(new SYS_Logger_Capability
                {
                    TacVu = "Đăng nhập",
                    ThoiGian = DateTime.Now,
                    Username = dbAccount.Username
                });
                //return the token
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Tài khoản hoặc mật khẩu không đúng");
            }
        }

    }
}
