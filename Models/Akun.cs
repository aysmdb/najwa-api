using System;
using System.Collections.Generic;

namespace Najwa_Api.Models {
    public class Akun {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Boolean isFinish { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}