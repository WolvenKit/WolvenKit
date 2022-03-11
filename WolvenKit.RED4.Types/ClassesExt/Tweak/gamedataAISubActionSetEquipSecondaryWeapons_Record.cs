
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetEquipSecondaryWeapons_Record
	{
		[RED("animationTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
