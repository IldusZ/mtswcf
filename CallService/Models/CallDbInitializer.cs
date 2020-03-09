﻿using System;
using System.Data.Entity;

namespace CallService.Models
{
    public class CallDbInitializer : DropCreateDatabaseAlways<CRMContext>
    {
        /// <summary>
        /// Заполняет базу данных при первом использовании контекста в домене приложения
        /// </summary>
        protected override void Seed(CRMContext context)
        {
            context.CallEvents.Add(new CallEvent { EventType = EventType.Call, PhoneFrom = "88002500890", PhoneTo = "89168569632" });
            context.CallEvents.Add(new CallEvent { EventType = EventType.Answer, PhoneFrom = "88002500890", PhoneTo = "89168569632" });
            context.CallEvents.Add(new CallEvent { EventType = EventType.HangUp, PhoneFrom = "88002500890", PhoneTo = "89168569632" });

            base.Seed(context);
        }
    }
}