using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystem : DeviceSystemBase
	{
		[Ordinal(97)] 
		[RED("savedOutputCache")] 
		public CArray<OutputValidationDataStruct> SavedOutputCache
		{
			get => GetPropertyValue<CArray<OutputValidationDataStruct>>();
			set => SetPropertyValue<CArray<OutputValidationDataStruct>>(value);
		}

		public SecuritySystem()
		{
			ControllerTypeName = "SecuritySystemController";
			SavedOutputCache = new();
		}
	}
}
