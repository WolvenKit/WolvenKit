using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SaveEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetProperty(ref _setType);
			set => SetProperty(ref _setType, value);
		}
	}
}
