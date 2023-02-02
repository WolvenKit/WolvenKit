
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIRestrictedMovementAreaCond_Record
	{
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
