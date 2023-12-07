
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetUnequipPrimaryWeapons_Record
	{
		[RED("UnequipDuration")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UnequipDuration
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
