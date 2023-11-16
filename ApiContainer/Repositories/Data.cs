using ApiContainer.Models;
using Newtonsoft.Json;

namespace ApiContainer.Repositories
{
    public static class Data
    {
        private static readonly string data = "[{\"CntrNo\":\"TTTT1000000\",\"CntrSize\":\"20\", \"OprId\":\"AEL\", \"Status\":\"F\", \"CMStatus\":\"S\"},{\"CntrNo\":\"IKON2000007\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000014\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000013\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000012\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000011\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000004\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON0000003\",\"CntrSize\":\"20\",\"OprId\":\"HMM\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"COLD0000001\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231240\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231239\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231238\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231237\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231236\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231234\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231233\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231232\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"SIRU1231231\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NYKU7130350\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"HARU5120681\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231238\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231236\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231234\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231233\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231232\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"DAEU1231231\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"HARU5120022\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"HARU5120830\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"HALU9001307\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231232\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231231\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231240\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231239\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231238\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231237\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231236\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VBNU1231235\",\"CntrSize\":\"40\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MPCU1709101\",\"CntrSize\":\"20\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"NHON1345678\",\"CntrSize\":\"20\",\"OprId\":\"AEL\",\"Status\":\"E\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"OTPU6259005\",\"CntrSize\":\"40\",\"OprId\":\"ONE\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"VOSU1813900\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MRKU4496660\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MRKU2148177\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"KDCU2163526\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MCCU3079262\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"TCNU2735999\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MRKU0462086\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"GLDU5185525\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"INKU2292937\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"},{ \"CntrNo\":\"MSKU6798228\",\"CntrSize\":\"20\",\"OprId\":\"MSK\",\"Status\":\"F\",\"CMStatus\":\"S\"}]";
        private static readonly List<Container> containersOld = JsonConvert.DeserializeObject<List<Container>>(data);
        private static readonly List<Container> containers = ConfigContainerList();

        public static readonly List<User> users = new List<User>
                    {
                        new User { Id = 1, Username="User1" , FullName="User name 1", Password="$2a$10$vACzQBnFm4jpgM2sPc0PdOxQuHLrj6J5ikr4jmBDzVChiaHPMRQKK"},
                        new User { Id = 2, Username="User2" , FullName="User name 2", Password="$2a$10$vACzQBnFm4jpgM2sPc0PdOxQuHLrj6J5ikr4jmBDzVChiaHPMRQKK"},
                        new User { Id = 3, Username="User3" , FullName="User name 3", Password="$2a$10$vACzQBnFm4jpgM2sPc0PdOxQuHLrj6J5ikr4jmBDzVChiaHPMRQKK"}
                    };

        public static readonly List<Category> categories = new List<Category>
        {
            new Category { OprId = "AEL", Name="AEL" },
            new Category { OprId = "ONE", Name="ONE" },
            new Category { OprId = "HMM", Name="HMM" },
            new Category { OprId = "MSK", Name="MSK" },
        };

        public static readonly List<Booking> bookings = new List<Booking>
        {
            new Booking { Id=Guid.NewGuid().ToString(), UserId = 1, User = users.FirstOrDefault(x => x.Id == 1), ContainerId = "TTTT1000000", Container=containers.FirstOrDefault(x => x.CntrNo =="TTTT1000000") },
            new Booking { Id=Guid.NewGuid().ToString(), UserId = 1, User = users.FirstOrDefault(x => x.Id == 1), ContainerId = "IKON2000007", Container=containers.FirstOrDefault(x => x.CntrNo =="IKON2000007") },
            new Booking { Id=Guid.NewGuid().ToString(), UserId = 1, User = users.FirstOrDefault(x => x.Id == 1), ContainerId = "NHON0000014", Container=containers.FirstOrDefault(x => x.CntrNo =="NHON0000014") },
        };




        public static List<Container> Containers => containers;

        private static List<Container> ConfigContainerList()
        {
            List<Container> containerList = new List<Container>();
            foreach (var c in containersOld)
            {
                if (c.CntrSize < 40)
                {
                    c.Thumbnail = new string[] { Constants.FAKE_THUMBNAIL_20, Constants.FAKE_THUMBNAIL_20, Constants.FAKE_THUMBNAIL_20 };
                }
                else
                {
                    c.Thumbnail = new string[] { Constants.FAKE_THUMBNAIL_40, Constants.FAKE_THUMBNAIL_40, Constants.FAKE_THUMBNAIL_40 };
                }
                containerList.Add(c);
            }

            return containerList;
        }
    }
}
