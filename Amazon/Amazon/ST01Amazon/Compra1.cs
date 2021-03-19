// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

[TestFixture]
public class Compra1Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void compra1() {

    driver.Navigate().GoToUrl("https://www.google.com.br/");
    driver.Navigate().GoToUrl("https://www.amazon.com.br/");

    driver.Manage().Window.Size = new System.Drawing.Size(1382, 744);

    var elements = driver.FindElements(By.Id("nav-logo-sprites"));
    Assert.True(elements.Count > 0);

    driver.FindElement(By.Id("twotabsearchtextbox")).Click();
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Memoria ram ddr4 8gb");
    driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys(Keys.Enter);
    driver.FindElement(By.CssSelector(".sg-col-4-of-12:nth-child(1) .s-image")).Click();
    Assert.That(driver.FindElement(By.Id("productTitle")).Text, Is.EqualTo("HX426C16FB3/8 - Memória HyperX Fury de 8GB DIMM DDR4 2666Mhz 1,2V para desktop"));
    Assert.That(driver.FindElement(By.CssSelector("#availability > .a-size-medium")).Text, Is.EqualTo("Em estoque."));
  
    var elements2 = driver.FindElements(By.Id("add-to-cart-button"));
    Assert.True(elements2.Count > 0);

    driver.FindElement(By.Id("add-to-cart-button")).Click();
    Assert.That(driver.FindElement(By.CssSelector("#huc-v2-order-row-confirm-text > .a-size-medium")).Text, Is.EqualTo("Adicionado ao carrinho"));
  }
}

/*
// Fecha a janela corrente.
driver.close();

// Encontra o primeiro elemento de uma tela HTML através de um dado argumento.
driver.findElement(By by);

// Encontra todos os elementos de uma tela HTML através de um dado argumento.
driver.findElements(By by);

// Abre uma nova URL no navegador.
driver.get();

// Retorna uma string que contém a URL aberta pelo navegador.
driver.getCurrentUrl();

// Retorna o código fonte da última página aberta pelo navegador.
driver.getPageSource();

// Retorna o título da página aberta pelo navegador.
driver.getTitle();

// Retorna um identificador da janela em questão.
driver.getWindowHandle();

// Retorna identificadores que podem ser utilizados para movimentação entre janelas.
driver.getWindowHandles();

// Envia comandos futuros para uma janela (ou frame) diferente.
driver.switchTo();

// Permite gerenciar cookies do navegador, logs, timeouts etc.
driver.manage();

// Abstração que permite acessar o histórico e navegar para uma determinada URL.
driver.navigate();

// Fecha a instância do Selenium WebDriver e todas os navegadores associados.
driver.quit();
*/