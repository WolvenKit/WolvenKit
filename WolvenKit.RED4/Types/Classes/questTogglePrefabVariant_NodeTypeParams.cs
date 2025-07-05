using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTogglePrefabVariant_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("variantStates")] 
		public CArray<questVariantState> VariantStates
		{
			get => GetPropertyValue<CArray<questVariantState>>();
			set => SetPropertyValue<CArray<questVariantState>>(value);
		}

		public questTogglePrefabVariant_NodeTypeParams()
		{
			VariantStates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
