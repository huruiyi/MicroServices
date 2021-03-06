﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using V3MsgService.Models;

namespace V3MsgService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpPost(nameof(Send_QQ))]
        public void Send_QQ(SendEmailRequest model)
        {
            Console.WriteLine($"通过QQ邮件接口向{model.Email}发送邮件，标题{model.Title}，内容：{model.Body}");
        }

        [HttpPost(nameof(Send_163))]
        public void Send_163(SendEmailRequest model)
        {
            Console.WriteLine($"通过网易邮件接口向{model.Email}发送邮件，标题{model.Title}，内容：{model.Body}");
        }

        [HttpPost(nameof(Send_Sohu))]
        public void Send_Sohu(SendEmailRequest model)
        {
            Console.WriteLine($"通过Sohu邮件接口向{model.Email}发送邮件，标题{model.Title}，内容：{model.Body}");
        }
    }
}