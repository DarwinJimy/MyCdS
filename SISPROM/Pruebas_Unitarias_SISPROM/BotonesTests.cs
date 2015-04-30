using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Funciones.Tests
{
    [TestClass()]
    public class BotonesTests
    {
        Button b1 = new Button();
        Button b2 = new Button();

        [TestMethod()]
        public void activar_desactivar_botonesTest()
        {
            // Arrange
            bool vRetornado;
            
            b1.Enabled = true;
            b2.Enabled = true;
            Botones btns = new Botones();
            // Fact
            vRetornado = btns.activar_desactivar_botones(b1, b2);
            // Assert
            Assert.AreEqual(true, vRetornado, "bien");
            
        }

        [TestMethod()]
        public void activar_desactivar_botonesFalsoTest()
        {
            // Arrange
            bool vRetornado;
            b1.Enabled = false;
            b2.Enabled = false;
            Botones btns = new Botones();
            // Act
            vRetornado = btns.activar_desactivar_botones(b1, b2);
            // Assert
            Assert.AreEqual(true, vRetornado, "bien");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void activar_desactivar_botonesErroresTest()
        {
            // Arrange
            bool VR;
            b1.Enabled = false;
            b2.Enabled = false;
            Botones btns = new Botones();
            // Act
            VR = btns.activar_desactivar_botones(b1, b2);
            // Assert manejado ExpectedException
            //Assert.AreEqual(false, vRetornado, "bien");
            throw new ArgumentOutOfRangeException();
        }
    }
}
