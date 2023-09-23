using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerMapObject : gameObject
	{
		[Ordinal(36)] 
		[RED("mapIndex")] 
		public CInt32 MapIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BunkerMapObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
