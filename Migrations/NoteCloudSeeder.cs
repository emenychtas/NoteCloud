using NoteCloud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCloud.Domain.Migrations
{
    public class NoteCloudSeeder
    {
        private readonly NoteCloudContext _ctx;

        public NoteCloudSeeder(NoteCloudContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            _ctx.Database.EnsureCreated();

            //if (!_ctx.Prod)
        }
    }
}
