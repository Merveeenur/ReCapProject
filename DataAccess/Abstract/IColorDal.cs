using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetAll();
        List<Color> GetAllById(int ColorId);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
