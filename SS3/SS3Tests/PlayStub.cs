using AutoFixture;
using SS3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3Tests
{
    public class PlayStub : IPlay
    {

        public List<PlayDB> getList()
        {
            List<PlayDB> res = new List<PlayDB>();
            var user1 = new Fixture().Build<PlayDB>()
                                    .With(u => u.Winner, "Победа X")
                                    .Create();
            res.Add(user1);
            var user2 = new Fixture().Build<PlayDB>()
                                   .With(u => u.Winner, "Победа X")
                                   .Create();
            res.Add(user2);
            var user3 = new Fixture().Build<PlayDB>()
                                   .With(u => u.Winner, "Победа 0")
                                   .Create();
            res.Add(user3);
            return res;
        }

        public bool hasFree(int[,] m)
        {
            throw new NotImplementedException();
        }

        public bool isWin(int[,] m)
        {
            throw new NotImplementedException();
        }

        public int[,] step(int x, int y, int[,] m)
        {
            throw new NotImplementedException();
        }
    }
}
