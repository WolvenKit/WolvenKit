
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBuildEquipmentSet_Record
	{
		[RED("equipment")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Equipment
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
