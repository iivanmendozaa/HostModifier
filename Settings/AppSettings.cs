using Newtonsoft.Json;
using System.IO;

namespace HostModifier.Settings
{

    /// <summary>
    /// Wrapped fuctions to easy control of Settings from JSON files.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Allow control of status of settings body
        /// </summary>
        private AppSettingsControl _AppSettingsControl;
        /// <summary>
        /// Path of Settings file
        /// </summary>
        private string settingsFile { get; set; } = "Settings.json";

        /// <summary>
        /// Main constructor of Class.
        /// </summary>
        public AppSettings() {

            _AppSettingsControl = new AppSettingsControl();
            _AppSettingsControl.settingsBody = File.ReadAllText(settingsFile);
        
        }

        /// <summary>
        /// Setting body as JSON String format.
        /// </summary>
        [JsonIgnore]
        public string SettingsBody => _AppSettingsControl.settingsBody;
        /// <summary>
        /// Path of loaded settings file
        /// </summary>
        [JsonIgnore]
        public string SettingPath => settingsFile;

        #region DTO Region here you can Add or Revome Settings parameters.

        /// <summary>
        /// Line to add to Host file.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string LineToAdd { get; set; }
        /// <summary>
        /// Path were Hosts file base is located.
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string HostsBasePath { get; set; }
       
        #endregion

        /// <summary>
        /// Allow control and state of JSON Settings Body.
        /// </summary>
        private class AppSettingsControl
        {
            /// <summary>
            /// Handle body of settins on JSON string format.
            /// </summary>
            public string settingsBody { get; set; }

        }
    }

  

   


}
