using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoLineEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stringId")] 
		public CRUID StringId
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("femaleResPath")] 
		public CResourceAsyncReference<locVoResource> FemaleResPath
		{
			get => GetPropertyValue<CResourceAsyncReference<locVoResource>>();
			set => SetPropertyValue<CResourceAsyncReference<locVoResource>>(value);
		}

		[Ordinal(2)] 
		[RED("maleResPath")] 
		public CResourceAsyncReference<locVoResource> MaleResPath
		{
			get => GetPropertyValue<CResourceAsyncReference<locVoResource>>();
			set => SetPropertyValue<CResourceAsyncReference<locVoResource>>(value);
		}

		public locVoLineEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
