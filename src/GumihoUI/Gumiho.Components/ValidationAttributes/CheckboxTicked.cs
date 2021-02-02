using System.ComponentModel.DataAnnotations;

namespace GumihoUI
{
    public class CheckboxTicked : ValidationAttribute
    {
        public override bool IsValid(object? value) =>
            value is not null && value is bool boolean && boolean;
    }
}
