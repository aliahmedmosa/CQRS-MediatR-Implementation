namespace App.Application.Features.Categories.Requests.Command
{
    public class CreateCategoryCommand : IRequest<Unit>
    {
        public CategoryDto CategoryDto { get; set; }
    }
}
