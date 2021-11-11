using NumberHit.Messages.Validation;

namespace NumberHit.Servises.IServises
{
    public interface INumberValidationServise
    {
        ValidationMessage ValidateNumber(string number);
    }
}
