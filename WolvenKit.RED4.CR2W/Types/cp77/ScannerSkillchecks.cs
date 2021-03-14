using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillchecks : ScannerChunk
	{
		private CArray<UIInteractionSkillCheck> _skillchecks;
		private CBool _authorizationRequired;
		private CBool _isPlayerAuthorized;

		[Ordinal(0)] 
		[RED("skillchecks")] 
		public CArray<UIInteractionSkillCheck> Skillchecks
		{
			get
			{
				if (_skillchecks == null)
				{
					_skillchecks = (CArray<UIInteractionSkillCheck>) CR2WTypeManager.Create("array:UIInteractionSkillCheck", "skillchecks", cr2w, this);
				}
				return _skillchecks;
			}
			set
			{
				if (_skillchecks == value)
				{
					return;
				}
				_skillchecks = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("authorizationRequired")] 
		public CBool AuthorizationRequired
		{
			get
			{
				if (_authorizationRequired == null)
				{
					_authorizationRequired = (CBool) CR2WTypeManager.Create("Bool", "authorizationRequired", cr2w, this);
				}
				return _authorizationRequired;
			}
			set
			{
				if (_authorizationRequired == value)
				{
					return;
				}
				_authorizationRequired = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isPlayerAuthorized")] 
		public CBool IsPlayerAuthorized
		{
			get
			{
				if (_isPlayerAuthorized == null)
				{
					_isPlayerAuthorized = (CBool) CR2WTypeManager.Create("Bool", "isPlayerAuthorized", cr2w, this);
				}
				return _isPlayerAuthorized;
			}
			set
			{
				if (_isPlayerAuthorized == value)
				{
					return;
				}
				_isPlayerAuthorized = value;
				PropertySet(this);
			}
		}

		public ScannerSkillchecks(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
