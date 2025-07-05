
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemBlueprint_Record
	{
		[RED("rootElement")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RootElement
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
