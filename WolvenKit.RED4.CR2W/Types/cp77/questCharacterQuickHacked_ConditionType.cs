using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterQuickHacked_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _quickHacked;

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
		[RED("quickHacked")] 
		public CBool QuickHacked
		{
			get
			{
				if (_quickHacked == null)
				{
					_quickHacked = (CBool) CR2WTypeManager.Create("Bool", "quickHacked", cr2w, this);
				}
				return _quickHacked;
			}
			set
			{
				if (_quickHacked == value)
				{
					return;
				}
				_quickHacked = value;
				PropertySet(this);
			}
		}

		public questCharacterQuickHacked_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
