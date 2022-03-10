
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNPCEquipmentGroup_Record
	{
		[RED("equipmentItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EquipmentItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
