using System.ComponentModel.DataAnnotations;

namespace ExamplesWASM
{
    public class SelectLowerThanFour : ValidationAttribute
    {
        public override bool IsValid(object? value) =>
            value is not null && value is int val && val >= 4;
    }
}
