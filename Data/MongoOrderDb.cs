﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Api.Model;
using MongoDB.Bson;

namespace Api.Data
{
    public class MongoOrderDb
    {
        protected static IMongoClient _client;
        protected static IMongoDatabase _database;
        private IMongoCollection<Order> _collection;
        private const string ConnectionString = "mongodb://test_db:27017";

        static MongoOrderDb()
        {
            _client = new MongoClient(ConnectionString);
            _database = _client.GetDatabase("test");
        }

        public MongoOrderDb()
        {
            _collection = _database.GetCollection<Order>("orders");
        }

        public async Task<string> InsertOrder(Order order)
        {
            string id = Guid.NewGuid().ToString();
            order.Id = id;
            await _collection.InsertOneAsync(order);
            return id;
        }

        public async Task<Order> GetOrder(string id)
        {
            var filter = Builders<Order>.Filter.Eq(x => x.Id, id);
            List<Order> orders = await _collection.Find(filter).ToListAsync();
            return orders.FirstOrDefault();
        }

        public async Task<List<Order>> GetOrders()
        {
            List<Order> orders = await _collection.Find(new BsonDocument()).ToListAsync();
            return orders;
        }
    }
}
