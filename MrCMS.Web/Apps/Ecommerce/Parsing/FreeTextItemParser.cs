using System.Text.RegularExpressions;
using MrCMS.Web.Apps.Ecommerce.Entities.NewsletterBuilder;
using MrCMS.Web.Apps.Ecommerce.Entities.NewsletterBuilder.ContentItems;

namespace MrCMS.Web.Apps.Ecommerce.Parsing
{
    public class FreeTextItemParser : INewsletterItemParser<FreeText>
    {
        private static readonly Regex TextRegex = new Regex(@"\[(?i)Text\]");

        public string Parse(NewsletterTemplate template, FreeText item)
        {
            string output = template.FreeTextTemplate;
            output = TextRegex.Replace(output, item.Text ?? string.Empty);
            return output;
        }
    }
}