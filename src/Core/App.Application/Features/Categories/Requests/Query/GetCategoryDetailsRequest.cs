namespace App.Application.Features.Categories.Requests.Query
{
    public class GetCategoryDetailsRequest:IRequest<CategoryDto>
    {
        public int Id { get; set; }
    }
}
