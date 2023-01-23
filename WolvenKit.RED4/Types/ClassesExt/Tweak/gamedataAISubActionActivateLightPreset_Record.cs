
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionActivateLightPreset_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lightPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LightPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
