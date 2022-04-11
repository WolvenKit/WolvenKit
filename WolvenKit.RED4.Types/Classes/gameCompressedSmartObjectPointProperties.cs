using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompressedSmartObjectPointProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propertyId")] 
		public CUInt16 PropertyId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}
	}
}
