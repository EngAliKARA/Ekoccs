
app.controller("EkoccsAngCtrl", function ($scope, crudAJService) {
    // $scope.divCustomer = false;
    GetAllCustomers();
    //To Get all book records  
    function GetAllCustomers() {
        // debugger;
        var getCustomerData = crudAJService.getCustomers();
        getCustomerData.then(function (result) {
            $scope.Customers = result.data;
        }, function () {
            alert('Kayıtlar Alınırken Hata oluştu!!!');
        });
    }
    function GetAllCitys() {
        // debugger;
        var getCustomerData = crudAJService.getCitys();
        getCustomerData.then(function (result) {
            $scope.Citys = result.data;
        }, function () {
            alert('City Kayıtlar Alınırken Hata oluştu!!!');
        });
    }
    $scope.editCustomer = function (customer) {
        var getCustomerData = crudAJService.getCustomer(customer.Id);
        getCustomerData.then(function (_customer) {
            $scope.Action = "Güncelle";
            $scope.customer = _customer.data;
            //alert(_customer.data.AdSoyad);  
            GetAllCitys();
            $("#myModal").modal("show");
        }, function () {
            alert('Müşteri Kaydı Alınırken Hata Oluştu!!!');
        });
    }


    $scope.AddUpdateCustomer = function () {
        var getAction = $scope.Action;
        var custom = $scope.customer;
        if (getAction == "Güncelle")
            var getCustomerData = crudAJService.updateCustomer(custom);
        else
            var getCustomerData = crudAJService.AddCustomer(custom);
        getCustomerData.then(function (msg) {
            GetAllCustomers();
            alert(msg.data);
            $("#myModal").modal("hide");
        }, function () {
            alert('Kayıt Ekleme ve Güncelleme İşleminde Hata Oluştu!!!');
        });
    }


    $scope.AddCustomer = function () {
        $scope.customer = null;
        $scope.CustomerId = null;
        $scope.Action = "Yeni ";
        GetAllCitys();
        $("#myModal").modal("show");
    }

    $scope.deleteCustomer = function (customer) {
        var getCustomerData = crudAJService.DeleteCustomer(customer.Id);
        getCustomerData.then(function (msg) {
            alert(msg.data);
            GetAllCustomers();
        }, function () {
            alert('Kayıt silinirken Problem oluştu');
        });
    }

    $scope.getPhoneList = function (Id) {
        $scope.CustomerId = Id;
        CustomerPhoneList(Id);
        $("#myphoneModal").modal("show");
    }

    function CustomerPhoneList(Id) {
        var getPhoneData = crudAJService.getPhones(Id);
        getPhoneData.then(function (_phones) {
            $scope.customerPhones = _phones.data;
        }, function () {
            alert('Kayıt silinirken Problem oluştu');
        });
    }

    $scope.deletephone = function (Id) {
        var getPhoneData = crudAJService.DeletePhone(Id);
        getPhoneData.then(function (msg) {
            alert(msg.data);
            CustomerPhoneList($scope.CustomerId);
        }, function () {
            alert('Kayıt silinirken Problem oluştu');
        });
    }
    $scope.InsertPhone = function (_newPhone) {
        var newPhone = _newPhone;
        newPhone.CustomerId = $scope.CustomerId;
        var getCustomerData = crudAJService.AddPhone(newPhone);
        getCustomerData.then(function (msg) {
            alert(msg.data);
            CustomerPhoneList($scope.CustomerId);
        }, function () {
            alert('Kayıt Ekleme ve Güncelleme İşleminde Hata Oluştu!!!');
        });
    }

    $scope.Pattern = /^([\w-]+(?:\.[\w-]+)*)((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{1,6}(?:\.[a-z]{2})?)$/i;  
    $scope.phoneNumbr = /^\+?\d{2}[- ]?\d{3}[- ]?\d{7}$/;
});




