﻿using StudentManagement.Shared.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentManagement.Services.Model
{
    public class VmStudent : IVm
    {

        public string? StudentName { get; set; }
        public double AdmissionFee { get; set; }
        public string? CourseNamme { get; set; }
        public int Id { get; set; }
        public int TeacherId { get; set; }
        [JsonIgnore]

        public VmTeacher? Teacher { get; set; }
    }
}

