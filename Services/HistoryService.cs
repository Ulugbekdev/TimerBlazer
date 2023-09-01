using System;
using TimerApp.Data;

namespace TimerApp.Services
{
    public class HistoryService
    {
        protected readonly ApplicationDBContext _dBContext;
        public HistoryService(ApplicationDBContext _db)
        {
            _dBContext = _db;
        }
        public List<History> displayHistory()
        {
            return _dBContext.history.ToList();
        }
        public void addHistory(string s, string e)
        {
            History data = new History{
                start_time = s,
                end_time = e
            };
            _dBContext.history.Add(data);
            _dBContext.SaveChanges();
        }
    }
}