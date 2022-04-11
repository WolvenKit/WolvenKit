using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entEntityID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}
	}
}
