using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePersistentStateDataResource : CResource
	{
		[Ordinal(1)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public gamePersistentStateDataResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
