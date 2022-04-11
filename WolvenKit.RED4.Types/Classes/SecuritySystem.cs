using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystem : DeviceSystemBase
	{
		[Ordinal(94)] 
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
