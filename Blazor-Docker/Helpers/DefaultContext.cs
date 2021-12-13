using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Blazor_Docker {
    public class DefaultContext : DbContext {

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) { }

    }
}