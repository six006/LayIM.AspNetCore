﻿using LayIM.AspNetCore.Core.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayIM.AspNetCore.Core.Routes
{
    internal static class LayIMUrls
    {
        public static string BuildUrl(string url)
        {
            return $"{LayIMServiceLocator.Options.ApiPrefix}{url}";
        }

        /// <summary>
        /// 路由：初始化
        /// </summary>
        public static readonly string LAYIM_ROUTE_INIT = "/init";
        /// <summary>
        /// 路由：配置
        /// </summary>
        public static readonly string LAYIM_ROUTE_CONFIG = "/config";
        /// <summary>
        /// 路由：上传图片
        /// </summary>
        public static readonly string LAYIM_ROUTE_UPLOAD_IMAGE = "/upload/img";
        /// <summary>
        /// 路由：上传文件
        /// </summary>
        public static readonly string LAYIM_ROUTE_UPLOAD_FILE = "/upload/file";
        /// <summary>
        /// 路由：获取群员列表
        /// </summary>
        public static readonly string LAYIM_ROUTE_GROUP_MEMBERS = "/group/members";
        /// <summary>
        /// 路由：获取TOKEN
        /// </summary>
        public static readonly string LAYIM_ROUTE_IM_TOKEN = "/token";

        internal static class Resources
        {
            /// <summary>
            /// 静态资源：/js/token.js
            /// </summary>
            public static readonly string LAYIM_JS_IM_SOCKET = "/js/socket.js";
            /// <summary>
            /// 静态资源：/js/rmlib.js
            /// </summary>
            public static readonly string LAYIM_JS_IM_RONG_LIB = "/js/rmlib.js";
            /// <summary>
            /// 静态资源：/js/protobuf.js
            /// </summary>
            public static readonly string LAYIM_JS_IM_PROTOBUF = "/js/protobuf.js";
            /// <summary>
            /// 入口js
            /// </summary>
            public static readonly string LAYIM_RESOURCE_INIT_JS = "socket";

            /// <summary>
            /// 静态资源：/page/find.html
            /// </summary>
            public static readonly string LAYIM_PAGE_FIND = "/page/find.html";
            /// <summary>
            /// 静态资源：/page/chatlog.html
            /// </summary>
            public static readonly string LAYIM_PAGE_CHATLOG = "/page/chatlog.html";
            /// <summary>
            /// 静态资源：/page/msgbox.html
            /// </summary>
            public static readonly string LAYIM_PAGE_MSGBOX = "/page/msgbox.html";
        }


    }
}
