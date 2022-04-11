using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDataChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}
	}
}
