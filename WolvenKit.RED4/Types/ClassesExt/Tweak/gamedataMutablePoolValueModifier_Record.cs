
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMutablePoolValueModifier_Record
	{
		[RED("delayOnChangeMod")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DelayOnChangeMod
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enabledMod")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EnabledMod
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rangeBeginMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RangeBeginMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("rangeEndMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> RangeEndMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("startDelayMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> StartDelayMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("valuePerSecMods")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> ValuePerSecMods
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
