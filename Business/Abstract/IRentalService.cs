using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract {
    public interface IRentalService {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> Get(int rentalId);
        IDataResult<List<RentalDetailDto>> GetDetails();
        IResult Add(Rental rental, CreditCard card);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<List<DateTime>> GetOccupiedDates(int carId);
    }
}
