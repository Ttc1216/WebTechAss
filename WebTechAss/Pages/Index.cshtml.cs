using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace WebTechAss.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly autismDBContext database;

        public IndexModel(ILogger<IndexModel> logger, autismDBContext database)
        {
            _logger = logger;
            this.database = database;
        }

        public void OnGet()
        {
            //linq
            //var categories = database.Resource.Where(x=>x.ResourceCategoryId==1).ToList();
            //foreach (var category in categories)
            //{
            //    category.ResourceAgeRangeId = 1;
            //}
            //database.Add(new ResourceCategory()
            //{
            //    Name = "xxx"
            //});
            //database.Remove(new ResourceCategory() { });
            //database.SaveChanges();
        }
    }
}