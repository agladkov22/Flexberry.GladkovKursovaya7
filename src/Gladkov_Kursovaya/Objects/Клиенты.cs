﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Gladkov_Kursovaya
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Клиенты.
    /// </summary>
    // *** Start programmer edit section *** (Клиенты CustomAttributes)

    // *** End programmer edit section *** (Клиенты CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("КлиентыE", new string[] {
            "ID as \'ID\'",
            "Наименование as \'Наименование\'",
            "Ответственный as \'Ответственный\'",
            "Телефон as \'Телефон\'",
            "Почта as \'Почта\'",
            "Банк as \'Банк\'",
            "РасСчет as \'Рас счет\'",
            "ИНН as \'ИНН\'"})]
    [View("КлиентыL", new string[] {
            "ID as \'ID\'",
            "Наименование as \'Наименование\'",
            "Ответственный as \'Ответственный\'",
            "Телефон as \'Телефон\'",
            "Почта as \'Почта\'",
            "Банк as \'Банк\'",
            "РасСчет as \'Рас счет\'",
            "ИНН as \'ИНН\'"})]
    public class Клиенты : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fНаименование;
        
        private string fОтветственный;
        
        private int fТелефон;
        
        private string fПочта;
        
        private string fБанк;
        
        private int fРасСчет;
        
        private int fИНН;
        
        // *** Start programmer edit section *** (Клиенты CustomMembers)

        // *** End programmer edit section *** (Клиенты CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.ID CustomAttributes)

        // *** End programmer edit section *** (Клиенты.ID CustomAttributes)
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.ID Get start)

                // *** End programmer edit section *** (Клиенты.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Клиенты.ID Get end)

                // *** End programmer edit section *** (Клиенты.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.ID Set start)

                // *** End programmer edit section *** (Клиенты.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Клиенты.ID Set end)

                // *** End programmer edit section *** (Клиенты.ID Set end)
            }
        }
        
        /// <summary>
        /// Банк.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Банк CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Банк CustomAttributes)
        [StrLen(255)]
        public virtual string Банк
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Банк Get start)

                // *** End programmer edit section *** (Клиенты.Банк Get start)
                string result = this.fБанк;
                // *** Start programmer edit section *** (Клиенты.Банк Get end)

                // *** End programmer edit section *** (Клиенты.Банк Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Банк Set start)

                // *** End programmer edit section *** (Клиенты.Банк Set start)
                this.fБанк = value;
                // *** Start programmer edit section *** (Клиенты.Банк Set end)

                // *** End programmer edit section *** (Клиенты.Банк Set end)
            }
        }
        
        /// <summary>
        /// ИНН.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.ИНН CustomAttributes)

        // *** End programmer edit section *** (Клиенты.ИНН CustomAttributes)
        public virtual int ИНН
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.ИНН Get start)

                // *** End programmer edit section *** (Клиенты.ИНН Get start)
                int result = this.fИНН;
                // *** Start programmer edit section *** (Клиенты.ИНН Get end)

                // *** End programmer edit section *** (Клиенты.ИНН Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.ИНН Set start)

                // *** End programmer edit section *** (Клиенты.ИНН Set start)
                this.fИНН = value;
                // *** Start programmer edit section *** (Клиенты.ИНН Set end)

                // *** End programmer edit section *** (Клиенты.ИНН Set end)
            }
        }
        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Наименование CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Наименование Get start)

                // *** End programmer edit section *** (Клиенты.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Клиенты.Наименование Get end)

                // *** End programmer edit section *** (Клиенты.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Наименование Set start)

                // *** End programmer edit section *** (Клиенты.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Клиенты.Наименование Set end)

                // *** End programmer edit section *** (Клиенты.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Ответственный.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Ответственный CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Ответственный CustomAttributes)
        [StrLen(255)]
        public virtual string Ответственный
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Ответственный Get start)

                // *** End programmer edit section *** (Клиенты.Ответственный Get start)
                string result = this.fОтветственный;
                // *** Start programmer edit section *** (Клиенты.Ответственный Get end)

                // *** End programmer edit section *** (Клиенты.Ответственный Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Ответственный Set start)

                // *** End programmer edit section *** (Клиенты.Ответственный Set start)
                this.fОтветственный = value;
                // *** Start programmer edit section *** (Клиенты.Ответственный Set end)

                // *** End programmer edit section *** (Клиенты.Ответственный Set end)
            }
        }
        
        /// <summary>
        /// Почта.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Почта CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Почта CustomAttributes)
        [StrLen(255)]
        public virtual string Почта
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Почта Get start)

                // *** End programmer edit section *** (Клиенты.Почта Get start)
                string result = this.fПочта;
                // *** Start programmer edit section *** (Клиенты.Почта Get end)

                // *** End programmer edit section *** (Клиенты.Почта Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Почта Set start)

                // *** End programmer edit section *** (Клиенты.Почта Set start)
                this.fПочта = value;
                // *** Start programmer edit section *** (Клиенты.Почта Set end)

                // *** End programmer edit section *** (Клиенты.Почта Set end)
            }
        }
        
        /// <summary>
        /// РасСчет.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.РасСчет CustomAttributes)

        // *** End programmer edit section *** (Клиенты.РасСчет CustomAttributes)
        public virtual int РасСчет
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.РасСчет Get start)

                // *** End programmer edit section *** (Клиенты.РасСчет Get start)
                int result = this.fРасСчет;
                // *** Start programmer edit section *** (Клиенты.РасСчет Get end)

                // *** End programmer edit section *** (Клиенты.РасСчет Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.РасСчет Set start)

                // *** End programmer edit section *** (Клиенты.РасСчет Set start)
                this.fРасСчет = value;
                // *** Start programmer edit section *** (Клиенты.РасСчет Set end)

                // *** End programmer edit section *** (Клиенты.РасСчет Set end)
            }
        }
        
        /// <summary>
        /// Телефон.
        /// </summary>
        // *** Start programmer edit section *** (Клиенты.Телефон CustomAttributes)

        // *** End programmer edit section *** (Клиенты.Телефон CustomAttributes)
        public virtual int Телефон
        {
            get
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Get start)

                // *** End programmer edit section *** (Клиенты.Телефон Get start)
                int result = this.fТелефон;
                // *** Start programmer edit section *** (Клиенты.Телефон Get end)

                // *** End programmer edit section *** (Клиенты.Телефон Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Клиенты.Телефон Set start)

                // *** End programmer edit section *** (Клиенты.Телефон Set start)
                this.fТелефон = value;
                // *** Start programmer edit section *** (Клиенты.Телефон Set end)

                // *** End programmer edit section *** (Клиенты.Телефон Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "КлиентыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыE", typeof(IIS.Gladkov_Kursovaya.Клиенты));
                }
            }
            
            /// <summary>
            /// "КлиентыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View КлиентыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("КлиентыL", typeof(IIS.Gladkov_Kursovaya.Клиенты));
                }
            }
        }
    }
}
