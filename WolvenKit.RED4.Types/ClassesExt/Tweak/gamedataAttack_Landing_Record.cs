
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttack_Landing_Record
	{
		[RED("fxPackage")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FxPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
