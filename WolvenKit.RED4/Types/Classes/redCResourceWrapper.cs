using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redCResourceWrapper : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("path")] 
		public redResourceReferenceScriptToken Path
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(1)] 
		[RED("cookingPlatform")] 
		public CEnum<ECookingPlatform> CookingPlatform
		{
			get => GetPropertyValue<CEnum<ECookingPlatform>>();
			set => SetPropertyValue<CEnum<ECookingPlatform>>(value);
		}

		public redCResourceWrapper()
		{
			Path = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
