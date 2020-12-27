using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    /// <summary>
    /// 
    /// <script type = "text/javascript" src="_content/blazing-IT.Components.Fontawesome/js/all.min.js"></script>
    /// </summary>
    public enum FaIconStyle
    {
        /// <summary>
        /// Availability: Pro required
        /// </summary>
        [CssClass("fal")]
        Light,

        /// <summary>
        /// Availability: Pro required
        /// </summary>
        [CssClass("far")]
        Regular,

        /// <summary>
        /// Availability: Free
        /// </summary>
        [CssClass("fas")]
        Solid,

        /// <summary>
        /// Availability: Pro required
        /// </summary>
        [CssClass("fad")]
        DuoTone,

        /// <summary>
        /// Availability: Free
        /// </summary>
        [CssClass("fab")]
        Brand
    }
}
