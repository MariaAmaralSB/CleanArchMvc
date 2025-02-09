using CleanArchMvc.Domain.Entities;
using FluentAssertions;


namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Created Product")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1,"Product Name","Product Description",9.99m,
                99,"product image");
            action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Created Product Invalid")]
        public void CreateProduct_WithInvalidParameters_ResultObjectInvalidState()
        {
            Action action = () => new Product(-1,"Product Name","Product Description",9.99m,
                99,"product image");
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }
    }
}
