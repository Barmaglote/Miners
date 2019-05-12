using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{

    public static class Util
    {
        public static T StringToEnum<T>(string name)
        {
            return (T)Enum.Parse(typeof(T), name);
        }

        public static string ToDescriptionString(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }

    public enum Keys
    {
        [Description("AmateurKey")]
        AmateurKey,
        [Description("MasterKey")]
        MasterKey,
        [Description("ProfessionalKey")]
        ProfessionalKey,
        [Description("DemonKey")]
        DemonKey
    }

    public static class Records
    {
        #region Properties
        private static readonly String SubKey = "MindMiner";
        private static readonly int Length = 10;
        public static Levels CurrentLevel;
        public enum Levels
        {
            Amateur = 0,
            Master = 1,
            Professional = 2,
            Demon = 3
        }

        public static int CurrentRecord
        {
            get {
                if (_CurrentRecord.HasValue) return (int)_CurrentRecord;
                return 999;
            }
            set {
                _CurrentRecord = value;
            }
        }

        private static int? _CurrentRecord = null;

        public static RegistryKey CurrentUserKey
        {
            get {
                return Registry.CurrentUser;
            }
        } 

        public static List<RecordItem> AmateurList
        {
            get {
                return GetList(Keys.AmateurKey);
            }
            set {
                SetValue(Keys.AmateurKey, value);
            }
        }
        public static List<RecordItem> MasterList {
            get {
                return GetList(Keys.MasterKey);
            }
            set
            {
                SetValue(Keys.MasterKey, value);
            }
        }
        public static List<RecordItem> ProfessionalList {
            get
            {
                return GetList(Keys.ProfessionalKey);
            }
            set
            {
                SetValue(Keys.ProfessionalKey, value);
            }
        }

        public static List<RecordItem> DemonList {
            get
            {
                return GetList(Keys.DemonKey);
            }
            set
            {
                SetValue(Keys.DemonKey, value);
            }
        }
        #endregion

        #region Methods    
        public static Boolean IsNewRecord(List<RecordItem> recordList, int time) {
            if (recordList.Count < Length) return true;
            return recordList.Any(x => x.Time >= time);
        }

        public static void AddRecord(List<RecordItem> list, RecordItem item)
        {
            list.Insert(GetPosition(list, item), item);
            AmateurList = list;
        }

        public static int GetPosition(List<RecordItem> list, RecordItem item)
        {
            if (list == null || list.Count == 0) return 0;

            return list.IndexOf(list.First(x => x.Time >= item.Time));            
        }

        public static List<RecordItem> GetList(Keys key)
        {
            List<RecordItem> list = new List<RecordItem>();
            try
            {
                RegistryKey minerKey = CurrentUserKey.OpenSubKey(SubKey, true);

                if (minerKey != null)
                {
                    for (int i = 0; i <= Length - 1; i++)
                    {
                        try
                        {
                            object name = minerKey.GetValue(key.ToDescriptionString() + "_name_" + i.ToString());
                            object time = minerKey.GetValue(key.ToDescriptionString() + "_time_" + i.ToString());

                            if ((name != null) && (time != null))
                            {
                                list.Add(new RecordItem(name.ToString(), (int)time));
                            }

                        }
                        catch { }
                    }
                }
                minerKey.Close();
            }
            catch
            {
                return list;
            }

            return list;
        }

        public static void SetValue(Keys key, List<RecordItem> value)
        {
            if (value != null)
            {
                RegistryKey minerKey = CurrentUserKey.CreateSubKey(SubKey);
                for (int i = 0; (i <= Length - 1 && i <= value.Count - 1); i++)
                {
                    minerKey.SetValue(key.ToDescriptionString() + "_name_" + i.ToString(), value[i].Name);
                    minerKey.SetValue(key.ToDescriptionString() + "_time_" + i.ToString(), value[i].Time);
                }
            }
        }
        #endregion

    }

    #region Class RecordItem
    public class RecordItem
    {
        public String Name;
        public int Time;

        public RecordItem(String Name, int Time)
        {
            this.Name = Name;
            this.Time = Time;
        }
    }
    #endregion
}
