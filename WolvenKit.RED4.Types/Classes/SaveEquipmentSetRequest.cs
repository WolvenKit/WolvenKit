using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetPropertyValue<CEnum<gameEquipmentSetType>>();
			set => SetPropertyValue<CEnum<gameEquipmentSetType>>(value);
		}

		public SaveEquipmentSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
