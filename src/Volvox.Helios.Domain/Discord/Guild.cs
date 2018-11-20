﻿using System.Collections.Generic;

namespace Volvox.Helios.Domain.Discord
{
    public class Guild
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public string ImageUrl { get; set; }

        public GuildDetails Details { get; set; }
    }
}