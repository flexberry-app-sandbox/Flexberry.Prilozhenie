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
    /// Здание.
    /// </summary>
    // *** Start programmer edit section *** (Здание CustomAttributes)

    // *** End programmer edit section *** (Здание CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ЗданиеE", new string[] {
            "Номер as \'Номер\'",
            "Город as \'Город\'",
            "Город.Наименование as \'Наименование\'"}, Hidden=new string[] {
            "Город.Наименование"})]
    [MasterViewDefineAttribute("ЗданиеE", "Город", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("ЗданиеL", new string[] {
            "Номер as \'Номер\'",
            "Город.Наименование as \'Наименование\'"})]
    public class Здание : ICSSoft.STORMNET.DataObject
    {
        
        private int fНомер;
        
        private int fвоЭтажей;
        
        private IIS.Prilozhenie.Город fГород;
        
        // *** Start programmer edit section *** (Здание CustomMembers)

        // *** End programmer edit section *** (Здание CustomMembers)

        
        /// <summary>
        /// воЭтажей.
        /// </summary>
        // *** Start programmer edit section *** (Здание.воЭтажей CustomAttributes)

        // *** End programmer edit section *** (Здание.воЭтажей CustomAttributes)
        private int воЭтажей
        {
            get
            {
                // *** Start programmer edit section *** (Здание.воЭтажей Get start)

                // *** End programmer edit section *** (Здание.воЭтажей Get start)
                int result = this.fвоЭтажей;
                // *** Start programmer edit section *** (Здание.воЭтажей Get end)

                // *** End programmer edit section *** (Здание.воЭтажей Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.воЭтажей Set start)

                // *** End programmer edit section *** (Здание.воЭтажей Set start)
                this.fвоЭтажей = value;
                // *** Start programmer edit section *** (Здание.воЭтажей Set end)

                // *** End programmer edit section *** (Здание.воЭтажей Set end)
            }
        }
        
        /// <summary>
        /// Номер.
        /// </summary>
        // *** Start programmer edit section *** (Здание.Номер CustomAttributes)

        // *** End programmer edit section *** (Здание.Номер CustomAttributes)
        public virtual int Номер
        {
            get
            {
                // *** Start programmer edit section *** (Здание.Номер Get start)

                // *** End programmer edit section *** (Здание.Номер Get start)
                int result = this.fНомер;
                // *** Start programmer edit section *** (Здание.Номер Get end)

                // *** End programmer edit section *** (Здание.Номер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.Номер Set start)

                // *** End programmer edit section *** (Здание.Номер Set start)
                this.fНомер = value;
                // *** Start programmer edit section *** (Здание.Номер Set end)

                // *** End programmer edit section *** (Здание.Номер Set end)
            }
        }
        
        /// <summary>
        /// Здание.
        /// </summary>
        // *** Start programmer edit section *** (Здание.Город CustomAttributes)

        // *** End programmer edit section *** (Здание.Город CustomAttributes)
        [PropertyStorage(new string[] {
                "Город"})]
        [NotNull()]
        public virtual IIS.Prilozhenie.Город Город
        {
            get
            {
                // *** Start programmer edit section *** (Здание.Город Get start)

                // *** End programmer edit section *** (Здание.Город Get start)
                IIS.Prilozhenie.Город result = this.fГород;
                // *** Start programmer edit section *** (Здание.Город Get end)

                // *** End programmer edit section *** (Здание.Город Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Здание.Город Set start)

                // *** End programmer edit section *** (Здание.Город Set start)
                this.fГород = value;
                // *** Start programmer edit section *** (Здание.Город Set end)

                // *** End programmer edit section *** (Здание.Город Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ЗданиеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗданиеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗданиеE", typeof(IIS.Prilozhenie.Здание));
                }
            }
            
            /// <summary>
            /// "ЗданиеL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ЗданиеL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ЗданиеL", typeof(IIS.Prilozhenie.Здание));
                }
            }
        }
    }
}
