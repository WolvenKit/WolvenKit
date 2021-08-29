using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SMeshTopology : RedBaseClass
	{
		private DataBuffer _data;
		private DataBuffer _metadata;

		[Ordinal(0)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("metadata")] 
		public DataBuffer Metadata
		{
			get => GetProperty(ref _metadata);
			set => SetProperty(ref _metadata, value);
		}
	}
}
