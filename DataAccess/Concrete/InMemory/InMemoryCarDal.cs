﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2020, DailyPrice = 170, Description = "Renault Megane Beyaz Renk"},
                new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = 2019, DailyPrice = 100, Description = "Renault Clio Beyaz Renk"},
                new Car { Id = 3, BrandId = 2, ColorId = 1, ModelYear = 2019, DailyPrice = 100, Description = "Hyundai i30 Beyaz Renk"},
                new Car { Id = 4, BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 150, Description = "Hyundai Tucson Siyah Renk"},
                new Car { Id = 5, BrandId = 3, ColorId = 3, ModelYear = 2020, DailyPrice = 200, Description = "Volkswagen Passat Gri Renk"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
