using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		[Ordinal(36)] 
		[RED("colorIndex")] 
		public CInt8 ColorIndex
		{
			get => GetPropertyValue<CInt8>();
			set => SetPropertyValue<CInt8>(value);
		}

		public gameNetrunnerPrototypeNetworkNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
