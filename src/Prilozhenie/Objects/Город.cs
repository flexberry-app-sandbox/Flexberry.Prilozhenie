﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Prilozhenie
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Город.
    /// </summary>
    // *** Start programmer edit section *** (Город CustomAttributes)

    // *** End programmer edit section *** (Город CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ГородE", new string[] {
            "Наименование as \'Наименование\'",
            "Площадь as \'Площадь\'"})]
    [View("ГородL", new string[] {
            "Наименование as \'Наименование\'",
            "Площадь as \'Площадь\'"})]
    public class Город : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private int fПлощадь;
        
        // *** Start programmer edit section *** (Город CustomMembers)

        // *** End programmer edit section *** (Город CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Город.Наименование CustomAttributes)

        // *** End programmer edit section *** (Город.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Город.Наименование Get start)

                // *** End programmer edit section *** (Город.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Город.Наименование Get end)

                // *** End programmer edit section *** (Город.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Город.Наименование Set start)

                // *** End programmer edit section *** (Город.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Город.Наименование Set end)

                // *** End programmer edit section *** (Город.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Площадь.
        /// </summary>
        // *** Start programmer edit section *** (Город.Площадь CustomAttributes)

        // *** End programmer edit section *** (Город.Площадь CustomAttributes)
        public virtual int Площадь
        {
            get
            {
                // *** Start programmer edit section *** (Город.Площадь Get start)

                // *** End programmer edit section *** (Город.Площадь Get start)
                int result = this.fПлощадь;
                // *** Start programmer edit section *** (Город.Площадь Get end)

                // *** End programmer edit section *** (Город.Площадь Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Город.Площадь Set start)

                // *** End programmer edit section *** (Город.Площадь Set start)
                this.fПлощадь = value;
                // *** Start programmer edit section *** (Город.Площадь Set end)

                // *** End programmer edit section *** (Город.Площадь Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ГородE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ГородE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ГородE", typeof(IIS.Prilozhenie.Город));
                }
            }
            
            /// <summary>
            /// "ГородL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ГородL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ГородL", typeof(IIS.Prilozhenie.Город));
                }
            }
        }
    }
}
