﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class IMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public IMemoryColorDal()
        {
            _colors = new List<Color> {
            new Color{ColorId =1 ,ColorName="Grey "},
            new Color{ColorId =1 ,ColorName="Black "},
            new Color{ColorId =1 ,ColorName="White "},
            new Color{ColorId =1 ,ColorName="Red "},

            };
        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAllById(int ColorId)
        {
            return _colors.Where(x => x.ColorId == ColorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}