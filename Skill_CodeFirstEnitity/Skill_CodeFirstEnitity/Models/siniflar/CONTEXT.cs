﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Skill_CodeFirstEnitity.Models.siniflar
{
    public class CONTEXT: DbContext
    {
        public DbSet<YETENEKLER> YETENEKLERS { get; set; }
    }
}