using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ManageRagdoll : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _enableRagdoll;

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
		[RED("enableRagdoll")] 
		public CBool EnableRagdoll
		{
			get
			{
				if (_enableRagdoll == null)
				{
					_enableRagdoll = (CBool) CR2WTypeManager.Create("Bool", "enableRagdoll", cr2w, this);
				}
				return _enableRagdoll;
			}
			set
			{
				if (_enableRagdoll == value)
				{
					return;
				}
				_enableRagdoll = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_ManageRagdoll(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
