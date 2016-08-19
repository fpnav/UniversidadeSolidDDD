using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DOMAIN.Entities;
using DOMAIN.Services;

namespace Testes
{
    [TestClass]
    public class AlunoTest
    {
        [TestMethod]
        public void TesteSeAlunoValido()
        {
            var aluno = new Aluno
            {
                Cpf = "12345678901",
                DataNascimento = new DateTime(1995, 01, 01),
                Email = "teste@teste.com",
                Id = 123123,
                Nome = "Joaoferson de Orleans e Bragança",
                RA = "123453"
            };

            Assert.IsTrue(aluno.IsValid());
        }
    }
}
