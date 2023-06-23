using Xunit;
namespace KinemaX.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_DistanciaMRU()
    {
        Movimiento movimiento = new Movimiento();
        float distancia = movimiento.mruD(10, 5);
        Assert.Equal(50, distancia);
    }
    
    [Fact]
    public void Test_VelocidadMRU()
        {
            Movimiento movimiento = new Movimiento();
            float velocidad = movimiento.mruV(10, 5);
            Assert.Equal(2, velocidad);
        }

    [Fact]
    public void Test_TiempoMRU()
        {
            Movimiento movimiento = new Movimiento();
            float tiempo = movimiento.mruT(20, 5);
            Assert.Equal(4, tiempo);
        }

        // Pruebas para Movimiento Rectilíneo Uniformemente Acelerado (MRUV)

        [Fact]
        public void Test_VelocidadMRUV()
        {
            Movimiento movimiento = new Movimiento();
            float velocidadFinal = movimiento.mruvVF(10, 2, 5);
            Assert.Equal(20, velocidadFinal);
        }

        [Fact]
        public void Test_DistanciaMRUV()
        {
            Movimiento movimiento = new Movimiento();
            float distancia = movimiento.mruvD(10, 2, 5);
            Assert.Equal(75, distancia);
        }

        [Fact]
        public void Test_AceleracionMRUV()
        {
            Movimiento movimiento = new Movimiento();
            float aceleracion = movimiento.mruvA(5, 10, 20);
            Assert.Equal(1.875, aceleracion);
        }

        [Fact]
        public void Test_TiempoMRUV()
        {
            Movimiento movimiento = new Movimiento();
            float tiempo = movimiento.mruvT(5, 20, 3);
            Assert.Equal(5, tiempo);
        }

        // Pruebas para Movimiento Circular Uniforme (MCU)

        [Fact]
        public void Test_VelocidadAngularMC()
        {
            Movimiento movimiento = new Movimiento();
            float velocidadAngular = movimiento.mcuW(5, 10);
            Assert.Equal((float)Math.PI, velocidadAngular);
        }

        [Fact]
        public void Test_TiempoMC()
        {
            Movimiento movimiento = new Movimiento();
            float tiempo = movimiento.mcuT(5, (float)Math.PI);
            Assert.Equal(10, tiempo);
        }

        // Pruebas para Movimiento Parabólico (MP)

        [Fact]
        public void Test_AlcanceHorizontalMP()
        {
            Movimiento movimiento = new Movimiento();
            float alcanceHorizontal = movimiento.mpAH(10, 45);
            Assert.Equal(10.19 alcanceHorizontal);
        }

        [Fact]
        public void Test_AlturaMaximaMP()
        {
            Movimiento movimiento = new Movimiento();
            float alturaMaxima = movimiento.mpAM(10, 45);
            Assert.Equal(2.54841998, alturaMaxima);
        }
    }
