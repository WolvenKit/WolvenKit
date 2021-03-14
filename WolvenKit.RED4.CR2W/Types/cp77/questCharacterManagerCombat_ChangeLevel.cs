using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_ChangeLevel : questICharacterManagerCombat_NodeSubType
	{
		private gameEntityReference _puppetRef;
		private questInt32ValueWrapper _level;
		private CBool _setExactLevel;

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
		[RED("level")] 
		public questInt32ValueWrapper Level
		{
			get
			{
				if (_level == null)
				{
					_level = (questInt32ValueWrapper) CR2WTypeManager.Create("questInt32ValueWrapper", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("setExactLevel")] 
		public CBool SetExactLevel
		{
			get
			{
				if (_setExactLevel == null)
				{
					_setExactLevel = (CBool) CR2WTypeManager.Create("Bool", "setExactLevel", cr2w, this);
				}
				return _setExactLevel;
			}
			set
			{
				if (_setExactLevel == value)
				{
					return;
				}
				_setExactLevel = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_ChangeLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
