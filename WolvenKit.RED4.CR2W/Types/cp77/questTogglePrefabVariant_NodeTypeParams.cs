using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTogglePrefabVariant_NodeTypeParams : CVariable
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

		public questTogglePrefabVariant_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
