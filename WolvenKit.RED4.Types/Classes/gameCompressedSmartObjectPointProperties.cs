using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompressedSmartObjectPointProperties : RedBaseClass
	{
		private CUInt16 _propertyId;

		[Ordinal(0)] 
		[RED("propertyId")] 
		public CUInt16 PropertyId
		{
			get => GetProperty(ref _propertyId);
			set => SetProperty(ref _propertyId, value);
		}
	}
}
