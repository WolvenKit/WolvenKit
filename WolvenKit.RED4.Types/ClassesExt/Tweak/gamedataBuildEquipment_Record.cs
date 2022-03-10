
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildEquipment_Record
	{
		[RED("equipment")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Equipment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
