﻿using System;
using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModel
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        public int Id { get; set; }

        public string ExistingPhotoPath { get; set; }
    }
}
