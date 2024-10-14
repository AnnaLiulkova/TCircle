using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCircle7;

namespace TCircle7.Tests
{
    [TestClass]
    public class TCircle7
    {
        [TestMethod]
        public void TestCircleArea()
        {
            TCircle circle = new TCircle(5);
            double area = circle.Area();

            Assert.AreEqual(Math.PI * 25, area, 0.0001, "����� ���� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleCircumference()
        {
            TCircle circle = new TCircle(5);
            double circumference = circle.Square();

            Assert.AreEqual(2 * Math.PI * 5, circumference, 0.0001, "������� ���� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleArea1()
        {
            TCircle circle = new TCircle(3);

            double area = circle.Area();
            Assert.AreEqual(Math.PI * Math.Pow(3, 2), area, 0.0001, "����� ���� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleCircumference1()
        {
            TCircle circle = new TCircle(4);

            double circumference = circle.Square();
            Assert.AreEqual(2 * Math.PI * 4, circumference, 0.0001, "������� ���� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleSectorArea()
        {
            TCircle circle = new TCircle(5);
            double angle = Math.PI / 4;

            double sectorArea = circle.SectorArea(angle);
            Assert.AreEqual(0.5 * Math.Pow(5, 2) * angle, sectorArea, 0.0001, "����� ������� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleSectorArea1()
        {
            TCircle circle = new TCircle(6);
            double angle = Math.PI / 2;
            double sectorArea = circle.SectorArea(angle);
            Assert.AreEqual(0.5 * Math.Pow(6, 2) * angle, sectorArea, 0.0001, "����� ������� ����������� �����������.");
        }

        [TestMethod]
        public void TestCircleAddition()
        {
            TCircle circle1 = new TCircle(11);
            TCircle circle2 = new TCircle(3);

            TCircle sumCircle = circle1 + circle2;
            Assert.AreEqual(14, sumCircle.Radius, "���� ������ ��������� �����������.");
        }

        [TestMethod]
        public void TestCircleSubtraction()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(5);

            TCircle diffCircle = circle1 - circle2;
            Assert.AreEqual(0, diffCircle.Radius, "г����� ������ ��������� �����������.");
        }

        [TestMethod]
        public void TestCircleEquality()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(5);

            Assert.IsTrue(circle1.Equals(circle2), "���� �� ������ ���� ������.");
        }

        [TestMethod]
        public void TestCircleNegativeRadiusThrowsException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => new TCircle(-5));
            Assert.AreEqual("����� �� ���� ���� ��'�����", ex.Message);
        }

        [TestMethod]
        public void TestCircleDefaultConstructor()
        {
            TCircle circle = new TCircle();

            Assert.AreEqual(1.0, circle.Radius, "����������� �� ������������� ������� ������������� ����� 1.");
        }

        [TestMethod]
        public void TestCircleParameterizedConstructor()
        {
            TCircle circle = new TCircle(5);
            Assert.AreEqual(5, circle.Radius, "����������� � ���������� ������� ������������� ����� ���������.");
        }

        [TestMethod]
        public void TestCircleZeroRadius()
        {
            TCircle circle = new TCircle(0);
            Assert.AreEqual(0, circle.Radius, "����� ������� ���� ����� 0, ���� ���� ����������� �� 0.");
        }

        [TestMethod]
        public void TestCircleAddition1()
        {
            TCircle circle1 = new TCircle(3);
            TCircle circle2 = new TCircle(4);

            TCircle result = circle1 + circle2;
            Assert.AreEqual(7, result.Radius, "���� ������ ��� �� ��������� ���������.");
        }

        [TestMethod]
        public void TestCircleSubtractionEqualRadii()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(5);

            TCircle result = circle1 - circle2;

            Assert.AreEqual(0, result.Radius, "����� ������� ���������� 0 ��� ������� ����� ������.");
        }

        [TestMethod]
        public void TestCircleSubtractionEqualRadii1()
        {
            TCircle circle1 = new TCircle(2);
            TCircle circle2 = new TCircle(8);

            TCircle result = circle1 - circle2;

            Assert.AreEqual(6, result.Radius, "����� ������� ���������� 0 ��� ������� ����� ������.");
        }

        [TestMethod]
        public void TestCircleSubtractionEqualRadii2()
        {
            TCircle circle1 = new TCircle(8);
            TCircle circle2 = new TCircle(2);

            TCircle result = circle1 - circle2;

            Assert.AreEqual(6, result.Radius, "����� ������� ���������� 0 ��� ������� ����� ������.");
        }

        [TestMethod]
        public void TestCircleMultiplication1()
        {
            TCircle circle = new TCircle(5);
            double multiplier = 2;

            TCircle result = circle * multiplier;
            Assert.AreEqual(10, result.Radius, "�������� ������ ���� ��������� �����������.");
        }
 
        [TestMethod]
        public void TestCircleMultiplicationByOne()
        {
            TCircle circle = new TCircle(7);

            TCircle result = circle * 1;
            Assert.AreEqual(7, result.Radius, "�������� �� 1 �� ������� �������� �����.");
        }

        [TestMethod]
        public void TestCircleTwoByMultiplication()
        {

            TCircle circle = new TCircle(7);

            TCircle result =2 * circle;
            Assert.AreEqual(14, result.Radius, "�������� �� 2 �� ������� �������� �����.");
        }

        [TestMethod]
        public void TestCircleEquality_True()
        {

            TCircle circle1 = new TCircle(9);
            TCircle circle2 = new TCircle(9);
            Assert.IsTrue(circle1.Equals(circle2), "���� � ���������� �������� ������ ���� ������.");
        }

        [TestMethod]
        public void TestCircleEquality_False()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(6);

            Assert.IsFalse(circle1.Equals(circle2), "���� � ������ �������� �� ������ ���� ������.");
        }

        [TestMethod]
        public void TestCircleNegativeRadiusThrowsException1()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => new TCircle(-0.8));
            Assert.AreEqual("����� �� ���� ���� ��'�����", ex.Message);
        }

        // ���� �� ��, �� ��� ����������� ������ �� ��������� ���������� Radius ��'���� �������� ����������
        [TestMethod]
        public void TestCircleSetNegativeRadiusDoesNothing()
        {
            TCircle circle = new TCircle(3);

            circle.Radius = -10; // �������� ���������� ��'����� �����
            Assert.AreEqual(3, circle.Radius, "����� �� ������� ���������� �� ��'���� ��������.");
        }

        // ���� �� ��, �� ��� ����������� ������ ����� ���������� Radius ��������� �������� ����������
        [TestMethod]
        public void TestCircleSetPositiveRadiusWorks()
        {

            TCircle circle = new TCircle(3);

            circle.Radius = 10;
            Assert.AreEqual(10, circle.Radius, "����� ������� ������������ �� ��������� ��������.");
        }

        [TestMethod]
        public void TestCircleToString()
        {
            TCircle circle = new TCircle(20);

            string result = circle.ToString();
            Assert.AreEqual("���� � ������� 20", result, "����� ToString ������� ������������ ���������.");
        }

        [TestMethod]
        public void TestConeVolume()
        {
            TCone cone = new TCone(5, 10);

            double volume = cone.Area();
            Assert.AreEqual((1.0 / 3) * Math.PI * Math.Pow(5, 2) * 10, volume, 0.0001, "��'�� ������ ������������ �����������.");
        }

        [TestMethod]
        public void TestConeAddition()
        {
            TCone cone1 = new TCone(5, 10);
            TCone cone2 = new TCone(3, 7);

            TCone sumCone = cone1 + cone2;

            Assert.AreEqual(8, sumCone.Radius, "���� ������ ��������� �����������.");
            Assert.AreEqual(17, sumCone.Height, "���� ����� ��������� �����������.");
        }

        [TestMethod]
        public void TestConeSubtraction()
        {
            TCone cone1 = new TCone(5, 10);
            TCone cone2 = new TCone(3, 7);

            TCone diffCone = cone1 - cone2;

            Assert.AreEqual(2, diffCone.Radius, "г����� ������ ��������� �����������.");
            Assert.AreEqual(3, diffCone.Height, "г����� ����� ��������� �����������.");
        }

        [TestMethod]
        public void TestConeMultiplication()
        {
            TCone cone = new TCone(5, 10);
            double multiplier = 2;

            TCone scaledCone = cone * multiplier;

            Assert.AreEqual(10, scaledCone.Radius, "�������� ������ ��������� �����������.");
            Assert.AreEqual(20, scaledCone.Height, "�������� ������ ��������� �����������.");
        }

        [TestMethod]
        public void TestConeEquality()
        {
            TCone cone1 = new TCone(5, 10);
            TCone cone2 = new TCone(5, 10);

            Assert.IsTrue(cone1.Equals(cone2), "������ �� ������ ���� ������.");
        }

        [TestMethod]
        public void TestConeNegativeHeightThrowsException()
        {
            var ex = Assert.ThrowsException<ArgumentException>(() => new TCone(5, -10));
            Assert.AreEqual("������ �� ���� ���� ��'�����", ex.Message);
        }

    }
}