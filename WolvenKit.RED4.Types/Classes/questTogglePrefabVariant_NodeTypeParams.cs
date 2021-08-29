using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTogglePrefabVariant_NodeTypeParams : RedBaseClass
	{
		private NodeRef _prefabNodeRef;
		private CArray<questVariantState> _variantStates;

		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get => GetProperty(ref _prefabNodeRef);
			set => SetProperty(ref _prefabNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("variantStates")] 
		public CArray<questVariantState> VariantStates
		{
			get => GetProperty(ref _variantStates);
			set => SetProperty(ref _variantStates, value);
		}
	}
}
