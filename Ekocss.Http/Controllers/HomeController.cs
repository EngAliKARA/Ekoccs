using EkoCcs.Core.Models;
using Ekocss.Http.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ekocss.Http.Controllers
{
    [Route("http/{action}")]
    public class HomeController : BaseController
    {
        #region CUSTOMER PROCESS
        [HttpPost]
        public HttpResponseMessage GetCustomerList()
        {
            var customers = _customerDao.GetCustomerList();
            if (customers == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, customers);
        }
        [HttpPost]
        public HttpResponseMessage GetCustomerDetail(int Id)
        {
            var customer = _customerDao.GetCustomerDetail(Id);

            if (customer == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);

            return Request.CreateResponse(HttpStatusCode.OK, customer);
        }
        [HttpPost]
        public HttpResponseMessage GetCityList()
        {
            var customers = _cityDao.GetCityList();
            if (customers == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, customers);
        }
        [HttpPost]
        public HttpResponseMessage InsertCustomer(Customer customer)
        {
            var customers = _customerDao.SaveCustomer(customer);
            if (customers == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, customers);
        }
        [HttpPut]
        public HttpResponseMessage UpdateCustomer(Customer customer)
        {
            _customerDao.UpdateCustomer(customer);
            return Request.CreateResponse(HttpStatusCode.OK,"Kayıt Başarıyla Güncellendi");

        }
        [HttpPost]
        public HttpResponseMessage DeleteCustomer(int Id)
        {
            _customerDao.DeleteCustomer(Id);
            return Request.CreateResponse(HttpStatusCode.OK, "Kayıt Silindi");
        }
        #endregion
        #region PHONE PROCESS
        [HttpPost]
        public HttpResponseMessage GetPhoneList(int Id)
        {
            var phones = _phoneDao.GetPhoneList(Id);
            if (phones == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, phones);
        }
        [HttpPost]
        public HttpResponseMessage DeletePhone(int Id)
        {
            _phoneDao.Deletephone(Id);
            return Request.CreateResponse(HttpStatusCode.OK, "Telefon Kaydı Silindi");
        }
        [HttpPost]
        public HttpResponseMessage InsertPhone(Phone phone)
        {
            var phonem = _phoneDao.SavePhone(phone);
            if (phonem == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);
            else
                return Request.CreateResponse(HttpStatusCode.OK, phonem);
        }
        #endregion
    }
}
