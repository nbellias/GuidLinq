using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuidLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyDoc> uuids = new List<MyDoc>()
            {
                new MyDoc {
                    UserId = "Dimitris"
                },
                new MyDoc {
                    UniqueDocId = Guid.NewGuid()
                },
                new MyDoc {
                    UserId = "Nikos"
                },
                new MyDoc {
                    UniqueDocId = Guid.NewGuid()
                },
                new MyDoc {
                    UniqueDocId = Guid.NewGuid(),
                    UserId = "Sokratis"
                }
            };

            Console.WriteLine(JsonConvert.SerializeObject(uuids.Where(x => x.UniqueDocId != Guid.Empty)));
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(uuids.Where(x => x.UserId != null)));
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(uuids.Where(x => x.UserId != null && x.UniqueDocId != Guid.Empty)));

        }
    }

    class MyDoc
    {
        public Guid UniqueDocId { get; set; }
        public string UserId { get; set; }
    }
}
