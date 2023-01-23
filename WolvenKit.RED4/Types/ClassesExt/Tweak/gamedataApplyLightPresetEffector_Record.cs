
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyLightPresetEffector_Record
	{
		[RED("lightPreset")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LightPreset
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
