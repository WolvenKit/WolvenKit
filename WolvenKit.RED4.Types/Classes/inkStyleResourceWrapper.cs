using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleResourceWrapper : ISerializable
	{
		[Ordinal(0)] 
		[RED("styleResource")] 
		public CResourceAsyncReference<inkStyleResource> StyleResource
		{
			get => GetPropertyValue<CResourceAsyncReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkStyleResource>>(value);
		}

		public inkStyleResourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
