using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SMeshStream : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("data")] 
		public SerializationDeferredDataBuffer Data
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<EMeshStreamType> Type
		{
			get => GetPropertyValue<CEnum<EMeshStreamType>>();
			set => SetPropertyValue<CEnum<EMeshStreamType>>(value);
		}

		public SMeshStream()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
