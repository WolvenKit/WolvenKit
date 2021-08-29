using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SMeshStream : RedBaseClass
	{
		private SerializationDeferredDataBuffer _data;
		private CEnum<EMeshStreamType> _type;

		[Ordinal(0)] 
		[RED("data")] 
		public SerializationDeferredDataBuffer Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<EMeshStreamType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
