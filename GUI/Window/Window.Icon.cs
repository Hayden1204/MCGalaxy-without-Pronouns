﻿/*
    Copyright 2015 MCGalaxy
    
    Dual-licensed under the Educational Community License, Version 2.0 and
    the GNU General Public License, Version 3 (the "Licenses"); you may
    not use this file except in compliance with the Licenses. You may
    obtain a copy of the Licenses at
    
    http://www.opensource.org/licenses/ecl2.php
    http://www.gnu.org/licenses/gpl-3.0.html
    
    Unless required by applicable law or agreed to in writing,
    software distributed under the Licenses are distributed on an "AS IS"
    BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
    or implied. See the Licenses for the specific language governing
    permissions and limitations under the Licenses.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MCGalaxy.Gui {
    public partial class Window : Form {
        
        Icon GetIcon() {
            byte[] data   = Convert.FromBase64String("AAABAAEAICAAAAEAIACoEAAAFgAAACgAAAAgAAAAQAAAAAEAIAAAAAAAABAAAAAAAAAAAAAAAAAAAAAA");
            Stream source = new MemoryStream(data);
            return new Icon(source);
        }

        // base 64 encoded galaxy.ico
        const string icon_source =
        "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" +
        "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=";
    }
}
