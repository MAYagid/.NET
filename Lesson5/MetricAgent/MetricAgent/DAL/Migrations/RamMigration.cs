﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricAgent.DAL.Migrations
{
    [Migration(1)]
    public class RamMigration : Migration
    {
        public override void Up()
        {
            Create.Table("rammetrics")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Value").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("rammetrics");
        }
    }
}
