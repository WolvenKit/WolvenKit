using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStorageType_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("storage")] 
		public CEnum<questStorage> Storage
		{
			get => GetPropertyValue<CEnum<questStorage>>();
			set => SetPropertyValue<CEnum<questStorage>>(value);
		}
	}
}
