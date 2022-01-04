﻿using HunterPie.Core.Architecture;
using HunterPie.Core.Settings;
using HunterPie.Core.Settings.Types;

namespace HunterPie.Core.Client.Configuration.Overlay
{
    public class DamageMeterWidgetConfig : IWidgetSettings
    {
        [SettingField("MOCK", "MOCK")]
        public Observable<bool> Initialize { get; set; } = true;
        
        [SettingField("MOCK", "MOCK")]
        public Observable<bool> Enabled { get; set; } = true;
        
        [SettingField("MOCK", "MOCK")]
        public Position Position { get; set; } = new(0, 0);
        
        [SettingField("MOCK", "MOCK")]
        public Observable<double> Opacity { get; set; } = 1;
        
        [SettingField("MOCK", "MOCK")]
        public Observable<double> Scale { get; set; } = 1;
        
        [SettingField("MOCK", "MOCK")]
        public Observable<bool> StreamerMode { get; set; } = false;

        [SettingField("ENABLE_DAMAGE_METER_SHOULD_HIGHLIGHT_MYSELF", "ENABLE_DAMAGE_METER_SHOULD_HIGHLIGHT_MYSELF_DESC")]
        public Observable<bool> ShouldHighlightMyself { get; set; } = false;

        [SettingField("ENABLE_DAMAGE_METER_SHOULD_BLUR_NAMES", "ENABLE_DAMAGE_METER_SHOULD_BLUR_NAMES_DESC")]
        public Observable<bool> ShouldBlurNames { get; set; } = false;
    }
}
