using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.CarId));

            if (result != null)
            {
                return new ErrorResult(Messages.NotCarImageAdded);
            }

            carImage.Date = DateTime.Now;
            carImage.ImagePath = FileHelper.Add(file);

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId == carId).Count;
            if (result > 15)
            {
                return new ErrorResult(Messages.CapacityFulled);

            }
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            var result = this.Get(carImage.Id);
            var Deleted = FileHelper.Delete(result.Data.ImagePath);
            if (Deleted.Success)
            {
                _carImageDal.Delete(carImage);
                return new SuccessResult(Messages.CarImageDeleted);
            }
            return new ErrorResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetById(int imagedId)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(imagedId));
        }

        private List<CarImage> CheckIfCarImageNull(int id)
        {
            var result = _carImageDal.GetAll(i => i.CarId == id).Any();
            if (!result)
            {
                return new List<CarImage>
                {
                    new CarImage
                    {
                        CarId = id,
                        Date= DateTime.Now,
                        ImagePath = "rental.jpg"
                    }
                };
            }
            return _carImageDal.GetAll(i => i.CarId == id);
        }

        public IResult Update(CarImage carImage, IFormFile file)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(p => p.Id == carImage.Id).ImagePath, file);

            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.Id == id), Messages.CarImageListed);

        }
    }
}
