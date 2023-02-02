using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeDefTreeVariable : ISerializable
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("readableName")] 
		public CName ReadableName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public LibTreeDefTreeVariable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
