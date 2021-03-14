using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrereq_ConditionType : questISystemConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _isObjectPlayer;
		private CHandle<gameIPrereq> _prereq;

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
		[RED("isObjectPlayer")] 
		public CBool IsObjectPlayer
		{
			get
			{
				if (_isObjectPlayer == null)
				{
					_isObjectPlayer = (CBool) CR2WTypeManager.Create("Bool", "isObjectPlayer", cr2w, this);
				}
				return _isObjectPlayer;
			}
			set
			{
				if (_isObjectPlayer == value)
				{
					return;
				}
				_isObjectPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get
			{
				if (_prereq == null)
				{
					_prereq = (CHandle<gameIPrereq>) CR2WTypeManager.Create("handle:gameIPrereq", "prereq", cr2w, this);
				}
				return _prereq;
			}
			set
			{
				if (_prereq == value)
				{
					return;
				}
				_prereq = value;
				PropertySet(this);
			}
		}

		public questPrereq_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
