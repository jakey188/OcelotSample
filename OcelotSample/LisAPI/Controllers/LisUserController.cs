﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Common;

namespace LisAPI.Controllers
{
    [Authorize("Permission")]
    [Route("lisapi/[controller]")]
    public class LisUserController : Controller
    {
        // GET api/values
        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "Lis用户服务"+DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss"), "所在服务器："+ Environment.MachineName +" OS:"+Environment.OSVersion.VersionString};
        }

        // GET api/values/5
        /// <summary>
        /// 按ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="value">值</param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">ID</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/")]
        public IEnumerable<string> ABC()
        {
            return new string[] { "Lis用户服务", "首页" };
        }
        /// <summary>
        /// 拒绝路由
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/lisapi/denied")]
        public IActionResult Denied()
        {
            return new JsonResult(new
            {
                Status = false,
                Message = "Lis你无权限访问"
            });
        }
        /// <summary>
        /// 健康检查
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("/health")]
        public IActionResult Health()
        {
            return Content("健康检查：正常");
        }
    }

    /// <summary>
    /// abc controller
    /// </summary>
    public class ABCController:Controller
    {
        /// <summary>
        /// KKK
        /// </summary>
        [HttpGet]
        public void KKK()
        {
           
        }
    }
}



