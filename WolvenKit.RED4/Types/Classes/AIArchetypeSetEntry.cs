using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIArchetypeSetEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("resource")] 
		public CResourceReference<AIArchetype> Resource
		{
			get => GetPropertyValue<CResourceReference<AIArchetype>>();
			set => SetPropertyValue<CResourceReference<AIArchetype>>(value);
		}

		public AIArchetypeSetEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
