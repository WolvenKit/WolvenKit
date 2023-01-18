
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCrowdSlotMovementPatternBase_Record
	{
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("settings")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Settings
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
