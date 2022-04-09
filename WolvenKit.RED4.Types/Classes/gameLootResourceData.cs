using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameLootResourceData : ISerializable
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameLootResourceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
