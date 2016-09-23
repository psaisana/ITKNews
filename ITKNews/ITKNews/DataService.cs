using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITKNews
{
    public static class DataService
    {
        public static IList<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article
                {
                    Title = "Schroen masterclass seals South’s second NPL Victoria title",
                    Author = "Staff Writers",
                    ArticleUrl = "http://www.cornerflag.com.au/schroen-masterclass-seals-souths-second-npl-victoria-title/"
                },
                new Article
                {
                    Title = "Greens lose as Victoria’s national NPL struggles continue",
                    Author = "Mark Gojszyk",
                    ArticleUrl = "http://www.cornerflag.com.au/greens-lose-victorias-national-npl-struggles-continue/"
                },
                new Article
                {
                    Title = "NPL Victoria Team of the Season: Central Midfielders",
                    Author = "Staff Writers",
                    ArticleUrl = "http://www.cornerflag.com.au/npl-victoria-team-of-the-season-central-midfielders-2016/"
                },
                new Article
                {
                    Title = "NPL Victoria Team of the Season: Attacking Midfield",
                    Author = "Staff Writers",
                    ArticleUrl = "http://www.cornerflag.com.au/npl-victoria-team-season-attacking-midfield-2016/"
                },
                new Article
                {
                    Title = "Carley ends short Hume stay",
                    Author = "Mark Gojszyk",
                    ArticleUrl = "http://www.cornerflag.com.au/carley-ends-short-hume-stay/"
                },
                new Article
                {
                    Title = "Venomous Vranesevic fires Kingston past Saints",
                    Author = "Damir Kulas",
                    ArticleUrl = "http://www.cornerflag.com.au/venomous-vranesevic-fires-kingston-past-saints/"
                }
            };
        }
    }
}
