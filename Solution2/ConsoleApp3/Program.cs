// Создать класс Invoice.
//В теле класса создать три поля int account, string customer, string provider,
//которые должны быть проинициализированы один раз (при создании экземпляра данного класса)
//без возможности их дальнейшего изменения.
//В теле класса создать два закрытых поля string article, int quantity
//Создать метод расчета стоимости заказа с НДС и без НДС.
//Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.

using System;
using ConsoleApp3;

class Program
{
    static void Main()
    {
        Invoice invoice = new Invoice(4, "qwer", "asdfgh");

        Console.WriteLine(invoice.ShowSumWithTax());
        Console.Write(invoice.ShowSumWithOutTax());
    }
}