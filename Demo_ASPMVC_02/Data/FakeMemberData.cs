using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Demo_ASPMVC_02.Data
{
    public class FakeMemberData
    {
        // En vrai... On utilisera un db « Visage choqué »
        public class Member
        {
            public int Id { get; set; }
            public required string Email { get; set; }
            public required string Pseudo { get; set; }
            public DateTime? BirthDate { get; set; }
            public required string HashPassword { get; set; }
            public bool AllowNewsletter { get; set; }
        }

        public static List<Member> Members { get; } = new List<Member>()
        {
            new Member
            {
                Id = 1,
                Email = "della.duck@techni.be",
                Pseudo = "Della",
                BirthDate = null,
                AllowNewsletter = false,
                HashPassword = "$argon2i$v=19$m=16,t=2,p=1$OGFNa3NrVUYzWnpPUVVURg$ETf/9KhZiXTFN4JKLXBH+A"
            },
            new Member
            {
                Id = 2,
                Email = "zaza.vanderquack@techni.be",
                Pseudo = "Zaza",
                BirthDate = new DateTime(2001, 3, 5),
                AllowNewsletter = true,
                HashPassword = "$argon2i$v=19$m=16,t=2,p=1$ZWRYaTFkck55T2M0UWs5Rw$vpG4UOlK0KfBDqLvD3Bnmw"
            }
        };
    }
}
