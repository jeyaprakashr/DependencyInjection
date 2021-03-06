﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using DataAccess.IRepository;

namespace WebAPIService.Models
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;

        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;

        }

        public List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }

        public List<Customer> GetCustomerEntities()
        {
            return _iCustomerRepository.GetCustomerEntities();
        }

        public bool AddCustomer()
        {
            return _iCustomerRepository.AddCustomer();
        }

    }
