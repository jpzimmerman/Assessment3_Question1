﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment3_Question1 {
    class Person {
        public const uint AGE_OF_MAJORITY = 18;

        public string   FirstName { get; set; }
        public string   LastName { get; set; }
        public uint     Age { get; set; }
        public string   EmailAddress { get; set; }
        public bool     IsAnAdult { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, uint personAge, string emailAddr) {
            FirstName = firstName;
            LastName = lastName;
            Age = personAge;
            EmailAddress = emailAddr;
        }

        public bool CheckIfAdult() {
            IsAnAdult = Age >= AGE_OF_MAJORITY;
            return IsAnAdult;
        }
    }
}
