﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Volvox.Helios.Domain.Discord
{
    public class UserGuild {
        public User User { get; set; }

        public Guild Guild { get; set; }

        public int Permissions { get; set; }
    }
}
