﻿using System.Collections.Generic;

namespace KeePassNatMsg.Entry
{
    public class EntryConfig
    {
        public HashSet<string> Allow = new HashSet<string>();
        public HashSet<string> Deny = new HashSet<string>();
        public string Realm = null;
    }
}
