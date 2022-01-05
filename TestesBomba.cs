using NUnit.Framework;
using DesativarBombaNS;

namespace Testes
{
    public class Testes
    {
        [Test]
        public void PassingTestBranco()
        {
            Assert.AreEqual("A bomba continua activa! Corta outro fio.", 
                DesativarBomba.verificacaoBranco("verde"));
        }

        [Test]
        public void FailingTestBranco()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoBranco("preto"));
        }
        
        [Test]
        public void PassingTestVermelho()
        {
            Assert.AreEqual("Muito bem! Bomba desactivada. Ufa...", 
                DesativarBomba.verificacaoVermelho("verde"));
        }

        [Test]
        public void FailingTestVermelho()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoVermelho("branco"));
        }
        
        [Test]
        public void PassingTestPreto()
        {
            Assert.AreEqual("A bomba continua activa! Corta outro fio.", 
                DesativarBomba.verificacaoPreto("roxo"));
        }

        [Test]
        public void FailingTestPreto()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoPreto("laranja"));
        }
        
        [Test]
        public void PassingTestLaranja()
        {
            Assert.AreEqual("Muito bem! Bomba desactivada. Ufa...", 
                DesativarBomba.verificacaoLaranja("preto"));
        }

        [Test]
        public void FailingTestLaranja()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoLaranja("branco"));
        }
        
        [Test]
        public void PassingTestVerde()
        {
            Assert.AreEqual("Muito bem! Bomba desactivada. Ufa...", 
                DesativarBomba.verificacaoVerde("branco"));
        }

        [Test]
        public void FailingTestVerde()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoVerde("vermelho"));
        }

        [Test]
        public void PassingTestRoxo()
        {
            Assert.AreEqual("A bomba continua activa! Corta outro fio.", 
                DesativarBomba.verificacaoRoxo("preto"));
        }

        [Test]
        public void FailingTestRoxo()
        {
            Assert.AreEqual("A bomba explodiu!", 
                DesativarBomba.verificacaoRoxo("roxo"));
        }
        
        
        [Test]
        public void CorEscolhidaInvalida()
        {
            Assert.AreEqual(false, 
                DesativarBomba.verificacaoCorValida("rosa"));
        }
        
        [Test]
        public void CorEscolhidaValida()
        {
            Assert.AreEqual(true, 
                DesativarBomba.verificacaoCorValida("verde"));
        }
    }
}