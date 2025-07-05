using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questReInitContainers_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("containerNodeRef")] 
		public NodeRef ContainerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("lootTables")] 
		public CArray<TweakDBID> LootTables
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(2)] 
		[RED("useAreaLoot")] 
		public CBool UseAreaLoot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questReInitContainers_NodeTypeParams()
		{
			LootTables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
