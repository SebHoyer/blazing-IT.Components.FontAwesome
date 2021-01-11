using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    /// <summary>
    /// All FontAwesome style classes as enum
    /// </summary>
    /// <remarks>
    /// Offical documentation about FontAwesome styles:
    /// https://fontawesome.com/how-to-use/on-the-web/referencing-icons/basic-use
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
