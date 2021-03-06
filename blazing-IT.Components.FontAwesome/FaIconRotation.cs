﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.FontAwesome
{
    /// <summary>
    /// All FontAwesome rotation classes as enum
    /// </summary>
    /// <remarks>
    /// Offical documentation about FontAwesome rotation:
    /// https://fontawesome.com/how-to-use/on-the-web/styling/rotating-icons
    /// </remarks>
    public enum FaIconRotation
    {
        [CssClass("")]
        None,

        [CssClass("fa-rotate-90")]
        Rotate90,

        [CssClass("fa-rotate-180")]
        Rotate180,

        [CssClass("fa-rotate-270")]
        Rotate270,

        [CssClass("fa-flip-horizontal")]
        FlipHorizontal,

        [CssClass("fa-flip-vertical")]
        FlipVertical,

        [CssClass("fa-flip-both")]
        FlipBoth,
    }
}
