namespace App.Application.Features.Categories.Requests.Command
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public CategoryDto CategoryDto { get; set; }
    }
}
