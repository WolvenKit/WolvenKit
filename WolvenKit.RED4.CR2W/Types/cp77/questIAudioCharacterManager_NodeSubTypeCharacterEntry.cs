using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIAudioCharacterManager_NodeSubTypeCharacterEntry : CVariable
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enableSubSystem;

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
		[RED("enableSubSystem")] 
		public CBool EnableSubSystem
		{
			get
			{
				if (_enableSubSystem == null)
				{
					_enableSubSystem = (CBool) CR2WTypeManager.Create("Bool", "enableSubSystem", cr2w, this);
				}
				return _enableSubSystem;
			}
			set
			{
				if (_enableSubSystem == value)
				{
					return;
				}
				_enableSubSystem = value;
				PropertySet(this);
			}
		}

		public questIAudioCharacterManager_NodeSubTypeCharacterEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
