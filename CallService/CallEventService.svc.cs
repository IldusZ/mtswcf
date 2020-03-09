using CallService.Models;
using System.Collections.Generic;
using System.Linq;

namespace CallService
{
    public class CallEventService : ICallEventService
    {
        private CRMContext db = new CRMContext();

        /// <summary>
        /// Возвращает событие по идентификатору
        /// </summary>
        public CallEvent GetCallEvent(string CallID)
        {
            long id = long.Parse(CallID);

            return db.CallEvents.Find(id);
        }

        /// <summary>
        /// Возвращает список событий
        /// </summary>
        public List<CallEvent> GetCallEventList()
        {
            return db.CallEvents.ToList();
        }

        /// <summary>
        /// Добавляет событие
        /// </summary>
        public CallEvent AddCallEvent(CallEvent callEvent)
        {                        
            db.CallEvents.Add(callEvent);
            db.SaveChanges();

            return callEvent;
        }
    }
}
