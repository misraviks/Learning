﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetBookApi.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "V1";
        public const string Base = Root + "/" + Version;

        public static class Posts {

            public const  string GetAll = Base +"/posts";
            public const  string Get = Base +"/posts/{id}";
            public const  string Create = Base +"/posts";
        }

    }
}
