using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterKilled_ConditionType : questICharacterConditionType
	{
		private gameEntityReference _objectRef;
		private CHandle<questComparisonParam> _comparisonParams;
		private CBool _killed;
		private CBool _unconscious;
		private CBool _defeated;

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

		[Ordinal(2)] 
		[RED("killed")] 
		public CBool Killed
		{
			get
			{
				if (_killed == null)
				{
					_killed = (CBool) CR2WTypeManager.Create("Bool", "killed", cr2w, this);
				}
				return _killed;
			}
			set
			{
				if (_killed == value)
				{
					return;
				}
				_killed = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("unconscious")] 
		public CBool Unconscious
		{
			get
			{
				if (_unconscious == null)
				{
					_unconscious = (CBool) CR2WTypeManager.Create("Bool", "unconscious", cr2w, this);
				}
				return _unconscious;
			}
			set
			{
				if (_unconscious == value)
				{
					return;
				}
				_unconscious = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("defeated")] 
		public CBool Defeated
		{
			get
			{
				if (_defeated == null)
				{
					_defeated = (CBool) CR2WTypeManager.Create("Bool", "defeated", cr2w, this);
				}
				return _defeated;
			}
			set
			{
				if (_defeated == value)
				{
					return;
				}
				_defeated = value;
				PropertySet(this);
			}
		}

		public questCharacterKilled_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
