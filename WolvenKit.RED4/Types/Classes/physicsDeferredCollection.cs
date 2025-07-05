using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsDeferredCollection : ISerializable
	{
		[Ordinal(0)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		public physicsDeferredCollection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
