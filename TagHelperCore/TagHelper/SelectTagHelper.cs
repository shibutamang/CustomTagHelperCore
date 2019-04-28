using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelperCore.Models;

namespace TagHelperCore
{
    [HtmlTargetElement("select-option")]
    public class SelectTagHelper : TagHelper
    {
        public List<CustomSelect> Options { get; set; }
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            string content = $"<select>";
            foreach (var item in Options)
            {
                content += "<option value=" + "{ item.Value}" + ">" + "{ item.Name }" + "</option>";
            }
            output.Content.SetHtmlContent(content);
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
