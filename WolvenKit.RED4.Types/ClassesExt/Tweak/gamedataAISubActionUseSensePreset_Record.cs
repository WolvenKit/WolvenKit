
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionUseSensePreset_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sensePreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SensePreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
