using NFine.Domain._03_Entity.test;
using NFine.Domain._04_IRepository.test;
using NFine.Repository.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Application.test
{
   public class TestApp
    {

        private ITestRepository testRepository = new TestRepository();


        public int Insert(DzkTest dzkTest) {


            return testRepository.Insert(dzkTest);

        }


    }
}
