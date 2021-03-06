﻿#if NET461

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace NeinLinq.Tests.DbAsyncQuery
{
    public class Config : DbConfiguration
    {
        public Config()
        {
            SetDefaultConnectionFactory(new LocalDbConnectionFactory("MSSQLLocalDB"));
        }
    }
}

#endif
