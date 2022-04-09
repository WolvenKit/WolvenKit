using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEntityInstanceData : ISerializable
	{
		[Ordinal(0)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public entEntityInstanceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
