using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInstancedMeshNode : worldCookedNode
	{
		[Ordinal(2)] 
		[RED("cookedWorldTransformsBuffer")] 
		public DataBuffer CookedWorldTransformsBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(3)] 
		[RED("version")] 
		public CUInt8 Version
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldInstancedMeshNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
