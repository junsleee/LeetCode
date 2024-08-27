using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.AzureRedis
{
    public class RedisSample
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("vc0827.redis.cache.windows.net:6380,password=tKD6g9h9I8SMCJw6zWhUZCSOCfqKQc4BsAzCaNNMLtg=,ssl=True,abortConnect=False\r\n ");
        public void AddToSet(string key, string value)
        {
            IDatabase db = redis.GetDatabase();
            db.SetAdd(new RedisKey(key), new RedisValue(value));
        }
        public string GetValueFromSet(string key)
        {
            IDatabase db = redis.GetDatabase();
            //db.SetPop(new RedisKey(key));
            RedisValue[] values = db.SetMembers(new RedisKey(key));
            return values[0].ToString();
        }
        public bool SetContains(string key, string value)
        {
            IDatabase db = redis.GetDatabase();
            //db.SetPop(new RedisKey(key));
            bool result = db.SetContains(new RedisKey(key), new RedisValue(value));
            return result;
        }
    }
}
