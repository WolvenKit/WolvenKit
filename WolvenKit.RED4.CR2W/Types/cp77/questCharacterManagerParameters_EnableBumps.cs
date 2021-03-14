using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_EnableBumps : questICharacterManagerParameters_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enable;
		private CEnum<AIinfluenceEBumpPolicy> _policy;

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
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enable")] 
		public CBool Enable
		{
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("policy")] 
		public CEnum<AIinfluenceEBumpPolicy> Policy
		{
			get
			{
				if (_policy == null)
				{
					_policy = (CEnum<AIinfluenceEBumpPolicy>) CR2WTypeManager.Create("AIinfluenceEBumpPolicy", "policy", cr2w, this);
				}
				return _policy;
			}
			set
			{
				if (_policy == value)
				{
					return;
				}
				_policy = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerParameters_EnableBumps(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
