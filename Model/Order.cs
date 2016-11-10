﻿namespace Api.Model
{
    public class Order
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string ItemId { get; set; }
        public int Quantity { get; set; }
    }
}