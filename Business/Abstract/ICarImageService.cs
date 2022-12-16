using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract {
    public interface ICarImageService {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
        IResult Add(IFormFile formFile, CarImage carImage);
        IResult Update(IFormFile formFile, CarImage carImage);
        IResult DeleteByCarId(int carId);
        IResult Delete(CarImage carImage);
        IResult AddMultiple(IFormFile[] files, CarImage carImage);
    }
}
