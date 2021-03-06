﻿using Pomelo.AspNetCore.TimedJob;

namespace HouseCrawler.Core
{
    public class CrawlerJobs : Job
    {
        [Invoke(Begin = "2018-05-01 00:00", Interval = 1000 * 3600, SkipWhileExecuting = true)]
        public void Run()
        {
            PinPaiGongYuHouseCrawler.Run();
            PeopleRentingCrawler.Run();
            DoubanHouseCrawler.Run();
            CCBHouesCrawler.Run();
            ZuberHouseCrawler.Run();
            MoGuHouseCrawler.Run();
        }
    }
}
