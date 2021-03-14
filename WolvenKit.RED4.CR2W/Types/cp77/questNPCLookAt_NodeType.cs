using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questNPCLookAt_NodeType : questISceneManagerNodeType
	{
		private gameEntityReference _puppetRef;
		private gameEntityReference _lookAtTargetRef;
		private CBool _assignLookAt;
		private CBool _refPlayer;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get
			{
				if (_puppetRef == null)
				{
					_puppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppetRef", cr2w, this);
				}
				return _puppetRef;
			}
			set
			{
				if (_puppetRef == value)
				{
					return;
				}
				_puppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lookAtTargetRef")] 
		public gameEntityReference LookAtTargetRef
		{
			get
			{
				if (_lookAtTargetRef == null)
				{
					_lookAtTargetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "lookAtTargetRef", cr2w, this);
				}
				return _lookAtTargetRef;
			}
			set
			{
				if (_lookAtTargetRef == value)
				{
					return;
				}
				_lookAtTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("assignLookAt")] 
		public CBool AssignLookAt
		{
			get
			{
				if (_assignLookAt == null)
				{
					_assignLookAt = (CBool) CR2WTypeManager.Create("Bool", "assignLookAt", cr2w, this);
				}
				return _assignLookAt;
			}
			set
			{
				if (_assignLookAt == value)
				{
					return;
				}
				_assignLookAt = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("refPlayer")] 
		public CBool RefPlayer
		{
			get
			{
				if (_refPlayer == null)
				{
					_refPlayer = (CBool) CR2WTypeManager.Create("Bool", "refPlayer", cr2w, this);
				}
				return _refPlayer;
			}
			set
			{
				if (_refPlayer == value)
				{
					return;
				}
				_refPlayer = value;
				PropertySet(this);
			}
		}

		public questNPCLookAt_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
