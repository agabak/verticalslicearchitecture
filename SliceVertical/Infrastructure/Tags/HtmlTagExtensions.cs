using HtmlTags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SliceVertical.Infrastructure.Tags
{
    public static class HtmlTagExtensions
    {
        public static HtmlTag AddPlaceholder(this HtmlTag tag, string placeholder)
        {
            return tag.Attr("placeholder", placeholder);
        }

        public static HtmlTag AddPattern(this HtmlTag tag, string pattern)
        {
            var retVal = tag.Data("pattern", pattern);
            return retVal;
        }

        public static HtmlTag AutoCapitalize(this HtmlTag tag)
        {
            return tag.Data("autocapitalize", "true");
        }
    }
}
