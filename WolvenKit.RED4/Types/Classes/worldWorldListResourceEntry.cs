using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldWorldListResourceEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("world")] 
		public CResourceAsyncReference<CResource> World
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(1)] 
		[RED("streamingWorld")] 
		public CResourceAsyncReference<CResource> StreamingWorld
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(2)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public worldWorldListResourceEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
