using EkoCcs.Data.DaoL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ekocss.Http.Helpers
{
    public class BaseController : ApiController
    {
        protected readonly CustomerDao _customerDao;
        protected readonly CityDao _cityDao;
        protected readonly PhoneDao _phoneDao;
        public BaseController()
        {
            _customerDao = new CustomerDao();
            _cityDao = new CityDao();
            _phoneDao = new PhoneDao();
        }
    }
}
