﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner_Iteration_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1.Tests
{
    [TestClass()]
    public class RechnerModelTests
    {
        [TestMethod()]
        public void Berechne_DivisionDurchNull_ErgibtUnendlich()
        {
            RechnerModel model = new RechnerModel();

            model.Operation = "/";
            model.ErsteZahl = 10;
            model.ZweiteZahl = 0;

            model.Berechne();

            Assert.AreEqual(Double.PositiveInfinity, model.Resultat);
        }
    }
}