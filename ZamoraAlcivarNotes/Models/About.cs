using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamoraAlcivarNotes.Models;

internal class About
{
    public string Title => "Zamora Alcívar Notes";
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/RobertoZamora422/ZamoraAlcivarNotes.git";
    public string Message => "Apasionado por la tecnología y la innovación.";
    public string Author => "Roberto Zamora Alcívar";
}