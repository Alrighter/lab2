using System;

namespace lab2_8
{
    class invoice
    {
        private int _account;
        private string _customer;
        private string _provider;

        private string _article;
        private int _quantity;
        private int _pricePerItem;

        public void login(int account, string customer, string provider){
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public void fillItem(string article, int quantity, int price){
            this._article = article;
            this._quantity = quantity;
            this._pricePerItem = price;
        }

        public double priceWithNDS(){
            double price = _quantity * _pricePerItem * 1.2f;
            return price;
        }
        public int priceWithoutNDS(){
            int price = _quantity * _pricePerItem;
            return price;
        }
        public void display(){
            Console.WriteLine($"Account: {_account}\nCustomer: {_customer}\nProvider: {_provider}\nProduct info:\nArticle: {_article}\nQuantity: {_quantity}\nPrice per item: {_pricePerItem}\nPrice without VAT: {priceWithoutNDS()}\nPrise with VAT: {priceWithNDS()}\n\nHave a good day!");
        }

    }
}
