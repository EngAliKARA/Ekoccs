﻿var app = angular.module("EkoccsApp", []);

app.directive('exportToCsv', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            var el = element[0];
            element.bind('click', function (e) {
                var table = document.getElementById('tblCustomer');
                var csvString = '';
                for (var i = 0; i < table.rows.length; i++) {
                    var rowData = table.rows[i].cells;
                    for (var j = 0; j < rowData.length; j++) {
                        csvString = csvString + rowData[j].innerHTML + ",";
                    }
                    csvString = csvString.substring(0, csvString.length - 1);
                    csvString = csvString + "\n";
                }
                csvString = csvString.substring(0, csvString.length - 1);
                var a = $('<a/>', {
                    style: 'display:none',
                    href: 'data:application/octet-stream;base64,' + window.btoa(unescape(encodeURIComponent(csvString))),
                    download: 'customerlist.csv'
                }).appendTo('body')
                a[0].click()
                a.remove();
            });
        }
    }
});
