using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCookedCollisionNode : worldCookedNode
	{
		[Ordinal(2)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public worldCookedCollisionNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
