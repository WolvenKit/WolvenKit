using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldPrefabInstanceData : ISerializable
	{
		[Ordinal(0)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public worldPrefabInstanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
