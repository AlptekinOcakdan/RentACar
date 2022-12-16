using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract {
    public interface IColorService {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> Get(int colorId);
        IResult Add(Color car);
        IResult Update(Color car);
        IResult Delete(Color car);
    }
}
