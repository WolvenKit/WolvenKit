using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystem : DeviceSystemBase
	{
		private CArray<OutputValidationDataStruct> _savedOutputCache;

		[Ordinal(97)] 
		[RED("savedOutputCache")] 
		public CArray<OutputValidationDataStruct> SavedOutputCache
		{
			get => GetProperty(ref _savedOutputCache);
			set => SetProperty(ref _savedOutputCache, value);
		}
	}
}
