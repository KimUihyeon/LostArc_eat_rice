using System;
using System.Collections.Generic;
using eat_rice_model.entity;
using eat_rice_model.entity.common;
using eat_rice_service.masterService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void Actor_생성_테스트()
        {
            Actor actor = Actor.Create();

            Assert.IsNotNull(actor);
        }


        [TestMethod]
        public void Actor_가디언토벌_선택()
        {
            Actor actor = Actor.Create();

            List<Subjugation> 가디언토벌리스트 = MasterService.GetSubjugationHomeworks();
            actor.DayHomeworks.Add(가디언토벌리스트[0]);

            Assert.IsNotNull(actor);
        }

    }
}
