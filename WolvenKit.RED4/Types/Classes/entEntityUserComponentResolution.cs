using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEntityUserComponentResolution : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("include")] 
		public CResourceAsyncReference<entEntityTemplate> Include
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(2)] 
		[RED("mode")] 
		public CEnum<entEntityUserComponentResolutionMode> Mode
		{
			get => GetPropertyValue<CEnum<entEntityUserComponentResolutionMode>>();
			set => SetPropertyValue<CEnum<entEntityUserComponentResolutionMode>>(value);
		}

		public entEntityUserComponentResolution()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
