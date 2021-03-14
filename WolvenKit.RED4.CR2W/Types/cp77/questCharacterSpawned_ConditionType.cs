using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterSpawned_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CHandle<questComparisonParam> _comparisonParams;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("comparisonParams")] 
		public CHandle<questComparisonParam> ComparisonParams
		{
			get
			{
				if (_comparisonParams == null)
				{
					_comparisonParams = (CHandle<questComparisonParam>) CR2WTypeManager.Create("handle:questComparisonParam", "comparisonParams", cr2w, this);
				}
				return _comparisonParams;
			}
			set
			{
				if (_comparisonParams == value)
				{
					return;
				}
				_comparisonParams = value;
				PropertySet(this);
			}
		}

		public questCharacterSpawned_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
