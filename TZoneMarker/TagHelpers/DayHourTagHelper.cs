using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TZoneMarker.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("ul", Attributes = "start-hour")]
    public class DayHourTagHelper : TagHelper
    {
        public DayHourTagHelper()
        {

        }
        public int StartHour { get; set; }
        public string DayStartClass { get; set; }
        public string DayMorClass { get; set; }
        public string DayDayClass { get; set; }
        public string DayEveClass { get; set; }
        public string DayNigClass { get; set; }
        public string DayBoundaryClass { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TagBuilder result = new TagBuilder("ul");

            StartHour = (24 + StartHour) % 24;
            int CurrentHour = StartHour;
            do
            {
                
                TagBuilder li = new TagBuilder("li");
                TagBuilder b = new TagBuilder("b");
                
                b.InnerHtml.Append(CurrentHour.ToString());
                if (Enumerable.Range(1, 7).Contains(CurrentHour))
                {
                    li.AddCssClass(DayNigClass);

                    li.InnerHtml.AppendHtml(b);
                }
                if (Enumerable.Range(8, 10).Contains(CurrentHour))
                {
                    li.AddCssClass(DayMorClass);

                    li.InnerHtml.AppendHtml(b);
                }
                if (Enumerable.Range(11, 18).Contains(CurrentHour))
                {
                    li.AddCssClass(DayEveClass);

                    li.InnerHtml.AppendHtml(b);
                }
                if (Enumerable.Range(19, 22).Contains(CurrentHour))
                {
                    li.AddCssClass(DayNigClass);

                    li.InnerHtml.AppendHtml(b);
                }
                if (CurrentHour == 23)
                {
                    li.AddCssClass(DayBoundaryClass);

                    li.InnerHtml.AppendHtml(b);
                }

                if (CurrentHour == 0)
                {

                    li.AddCssClass(DayStartClass);
                    TagBuilder div = new TagBuilder("div");
                    div.InnerHtml.Append("Sat");
                    TagBuilder tag_b = new TagBuilder("b");
                    tag_b.InnerHtml.Append("May");
                    TagBuilder tag_i = new TagBuilder("i");
                    tag_i.InnerHtml.Append("22");
                    li.InnerHtml.AppendHtml(div);
                    li.InnerHtml.AppendHtml(tag_b);
                    li.InnerHtml.AppendHtml(tag_i);
                }

                result.InnerHtml.AppendHtml(li);
                CurrentHour = (CurrentHour + 1) % 24;

            } while (CurrentHour != StartHour);

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
