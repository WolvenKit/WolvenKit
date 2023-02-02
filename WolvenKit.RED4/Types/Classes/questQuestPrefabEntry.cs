using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questQuestPrefabEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public questQuestPrefabEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
