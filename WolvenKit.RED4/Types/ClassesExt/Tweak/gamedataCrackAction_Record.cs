
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCrackAction_Record
	{
		[RED("effector")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Effector
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
