using Newtonsoft.Json;
using System;
using System.IO;

namespace HostModifier.Settings
{
    /// <summary>
    /// Allow to control update and loading of Settings from JSON files.
    /// </summary>
    public static class SettingsControl
    {

        /// <summary>
        /// Load settings from JSON File to AppSetting Object by refence.
        /// </summary>
        /// <param name="appSettings"></param>
        public static void Load(ref AppSettings appSettings) 
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.MissingMemberHandling = MissingMemberHandling.Error;
            settings.NullValueHandling = NullValueHandling.Include;
            try
            {
                appSettings = JsonConvert.DeserializeObject<AppSettings>(appSettings.SettingsBody, settings);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Update settings file according data on Object AppSettings
        /// </summary>
        /// <param name="appSettings"></param>
        public static void Update(ref AppSettings appSettings)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();

            jsonSerializerSettings.Formatting = Formatting.Indented;

            string settingsBody = JsonConvert.SerializeObject(appSettings, jsonSerializerSettings);
            File.WriteAllText(appSettings.SettingPath, settingsBody, System.Text.Encoding.UTF8);
        }

    }
}
