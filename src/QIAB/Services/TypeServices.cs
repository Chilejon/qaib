using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QIAB.Models;

namespace QIAB.Services
{
    public class TypeServices
    {
        private QIABContext _context;

        public TypeServices()
        {
        }

        public TypeServices(QIABContext context)
        {
            _context = context;
        }

        public bool IsAlreadyType(string type)
        {
            var results = _context.QuestionTypes.ToList().Where(x => x.Type == type);

            if (results != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
