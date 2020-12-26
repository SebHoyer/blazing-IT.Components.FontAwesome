using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    public enum FaIconStyle
    {
        [CssClass("fat?")]
        Thin,

        [CssClass("fal")]
        Light,

        [CssClass("far")]
        Regular,

        [CssClass("fas")]
        Solid,

        [CssClass("fad")]
        DuoTone,

        [CssClass("fab")]
        Brand
    }
}
