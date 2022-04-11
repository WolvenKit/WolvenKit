using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class redResourceReferenceScriptToken : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<CResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		public redResourceReferenceScriptToken()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
