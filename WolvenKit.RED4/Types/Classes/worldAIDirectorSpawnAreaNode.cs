using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("groupKey")] 
		public CName GroupKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public worldAIDirectorSpawnAreaNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
