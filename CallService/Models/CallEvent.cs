using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CallService.Models
{
    /// <summary>
    /// События на АТС
    /// </summary>
    [DataContract]
    public class CallEvent
    {
        /// <summary>
        /// Уникальный идентификатор вызова
        /// </summary>
        [Key]
        [DataMember(Name = "Id")]
        public long Id { get; set; }

        /// <summary>
        /// Тип вызова (начало звонка, ответ оператора, завершение звонка)
        /// </summary>
        [DataMember(Name = "EventType")]
        public EventType EventType { get; set; }

        /// <summary>
        /// Номер абонента инициализировавшего вызов
        /// </summary>
        [DataMember(Name = "PhoneFrom")]
        public string PhoneFrom { get; set; }

        /// <summary>
        /// Номер назначения 
        /// </summary>
        [DataMember(Name = "PhoneTo")]
        public string PhoneTo { get; set; }
    }

    /// <summary>
    /// Типы вызовов
    /// </summary>
    public enum EventType
    {
        /// <summary>
        /// Начало звонка
        /// </summary>
        Call = 1,

        /// <summary>
        /// Ответ оператора на вызов
        /// </summary>
        Answer = 2,

        /// <summary>
        /// Завершение звонка
        /// </summary>
        HangUp = 3
    }
}