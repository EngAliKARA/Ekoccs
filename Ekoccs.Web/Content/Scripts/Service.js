app.service("crudAJService", function ($http) {

    //get All Customer
    this.getCustomers = function () {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/GetCustomerList",
        });
        return response;
    };
    this.getCitys = function () {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/GetCityList",
        });
        return response;
    };
    // get Customer by Id
    this.getCustomer = function (CustomerId) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/GetCustomerDetail",
            params: {
                Id: JSON.stringify(CustomerId)
            }
        });
        return response;
    }

    // Update Customer
    this.updateCustomer = function (customer) {
        var response = $http({
            method: "PUT",
            url: "http://localhost:49367/http/UpdateCustomer",
            data: JSON.stringify(customer),
            dataType: "json"
        });
        console.log(customer);
        return response;
    }

    // Add Customer
    this.AddCustomer = function (customer) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/InsertCustomer",
            data: JSON.stringify(customer),
            dataType: "json"
        });
        return response;
    }

    //Delete Customer
    this.DeleteCustomer = function (customerId) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/DeleteCustomer",
            params: {
                Id: JSON.stringify(customerId)
            }
        });
        return response;
    }

    this.getPhones = function (phoneId) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/GetPhoneList",
            params: {
                Id: JSON.stringify(phoneId)
            }
        });
        return response;
    }

    this.AddPhone = function (phone) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/InsertPhone",
            data: JSON.stringify(phone),
            dataType: "json"
        });
        return response;
    }

    this.DeletePhone = function (phoneId) {
        var response = $http({
            method: "post",
            url: "http://localhost:49367/http/DeletePhone",
            params: {
                Id: JSON.stringify(phoneId)
            }
        });
        return response;
    }
});

