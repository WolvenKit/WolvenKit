
namespace WolvenKit.RED4.Types
{
	public partial class gamedataApplyStatGroupEffector_Record
	{
		[RED("statGroup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
