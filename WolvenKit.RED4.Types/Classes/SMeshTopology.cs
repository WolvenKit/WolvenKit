using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SMeshTopology : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("metadata")] 
		public DataBuffer Metadata
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}
	}
}
