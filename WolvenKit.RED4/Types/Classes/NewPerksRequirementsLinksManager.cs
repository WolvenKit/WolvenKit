using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksRequirementsLinksManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("cache")] 
		public CArray<CHandle<NewPerksRequirementsLinks>> Cache
		{
			get => GetPropertyValue<CArray<CHandle<NewPerksRequirementsLinks>>>();
			set => SetPropertyValue<CArray<CHandle<NewPerksRequirementsLinks>>>(value);
		}

		public NewPerksRequirementsLinksManager()
		{
			Cache = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
