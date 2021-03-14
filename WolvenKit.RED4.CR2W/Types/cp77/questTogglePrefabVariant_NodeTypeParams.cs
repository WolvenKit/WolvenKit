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
			get
			{
				if (_prefabNodeRef == null)
				{
					_prefabNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefabNodeRef", cr2w, this);
				}
				return _prefabNodeRef;
			}
			set
			{
				if (_prefabNodeRef == value)
				{
					return;
				}
				_prefabNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variantStates")] 
		public CArray<questVariantState> VariantStates
		{
			get
			{
				if (_variantStates == null)
				{
					_variantStates = (CArray<questVariantState>) CR2WTypeManager.Create("array:questVariantState", "variantStates", cr2w, this);
				}
				return _variantStates;
			}
			set
			{
				if (_variantStates == value)
				{
					return;
				}
				_variantStates = value;
				PropertySet(this);
			}
		}

		public questTogglePrefabVariant_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
