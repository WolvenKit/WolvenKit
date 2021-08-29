using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStorageType_ConditionType : questISystemConditionType
	{
		private CEnum<questStorage> _storage;

		[Ordinal(0)] 
		[RED("storage")] 
		public CEnum<questStorage> Storage
		{
			get => GetProperty(ref _storage);
			set => SetProperty(ref _storage, value);
		}
	}
}
