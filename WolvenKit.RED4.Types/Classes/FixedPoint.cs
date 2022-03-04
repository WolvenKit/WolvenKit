using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class FixedPoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Bits")] 
		public CInt32 Bits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
