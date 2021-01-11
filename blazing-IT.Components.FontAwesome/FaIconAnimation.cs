using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    /// <summary>
    /// All FontAwesome animation classes as enum
    /// </summary>
    /// <remarks>
    /// Offical documentation about FontAwesome animation:
    /// https://fontawesome.com/how-to-use/on-the-web/styling/animating-icons
    /// </remarks>
    public enum FaIconAnimation
    {
        [CssClass("")]
        None,

        [CssClass("fa-spin")]
        Spin,

        [CssClass("fa-pulse")]
        Pulse
    }
}
