﻿using StudentManagement.Shared.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Services.Model
{
    public class VmStudent : IVm
    {
        public int Id { get ; set; }
        public string? StudentName { get; set; }
        public string? AdmissionFee { get; set; }

        public string? CourseNamme { get; set; }
    }
}
