using System.Configuration;

namespace _50PSAM
{
    public class Settings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool RunOnStartup
        {
            get
            {
                return ((bool)this["RunOnStartup"]);
            }
            set
            {
                this["RunOnStartup"] = (bool)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("100")]
        public int RefreshTimerInterval
        {
            get
            {
                return ((int)this["RefreshTimerInterval"]);
            }
            set
            {
                this["RefreshTimerInterval"] = (int)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool RunMinimized
        {
            get
            {
                return ((bool)this["RunMinimized"]);
            }
            set
            {
                this["RunMinimized"] = (bool)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool RunHidden
        {
            get
            {
                return ((bool)this["RunHidden"]);
            }
            set
            {
                this["RunHidden"] = (bool)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool HideOnClosing
        {
            get
            {
                return (bool)this["HideOnClosing"];
            }
            set
            {
                this["HideOnClosing"] = (bool)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("1")]
        public int RefreshTimer2Interval
        {
            get
            {
                return (int)this["RefreshTimer2Interval"];
            }
            set
            {
                this["RefreshTimer2Interval"] = (int)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool AutoRefresh
        {
            get
            {
                return (bool)this["AutoRefresh"];
            }
            set
            {
                this["AutoRefresh"] = (bool)value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool ShowNotifications
        {
            get
            {
                return (bool)this["ShowNotifications"];
            }
            set
            {
                this["ShowNotifications"] = (bool)value;
            }
        }
    }
}
