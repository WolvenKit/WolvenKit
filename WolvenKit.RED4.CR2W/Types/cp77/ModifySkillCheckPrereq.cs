using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifySkillCheckPrereq : gamePlayerScriptableSystemRequest
	{
		private CBool _register;
		private CHandle<SkillCheckPrereqState> _skillCheckState;

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CBool) CR2WTypeManager.Create("Bool", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skillCheckState")] 
		public CHandle<SkillCheckPrereqState> SkillCheckState
		{
			get
			{
				if (_skillCheckState == null)
				{
					_skillCheckState = (CHandle<SkillCheckPrereqState>) CR2WTypeManager.Create("handle:SkillCheckPrereqState", "skillCheckState", cr2w, this);
				}
				return _skillCheckState;
			}
			set
			{
				if (_skillCheckState == value)
				{
					return;
				}
				_skillCheckState = value;
				PropertySet(this);
			}
		}

		public ModifySkillCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
