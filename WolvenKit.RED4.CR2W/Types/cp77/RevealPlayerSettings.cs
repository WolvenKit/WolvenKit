using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealPlayerSettings : CVariable
	{
		private CEnum<ERevealPlayerType> _revealPlayer;
		private CBool _revealPlayerOutsideSecurityPerimeter;

		[Ordinal(0)] 
		[RED("revealPlayer")] 
		public CEnum<ERevealPlayerType> RevealPlayer
		{
			get
			{
				if (_revealPlayer == null)
				{
					_revealPlayer = (CEnum<ERevealPlayerType>) CR2WTypeManager.Create("ERevealPlayerType", "revealPlayer", cr2w, this);
				}
				return _revealPlayer;
			}
			set
			{
				if (_revealPlayer == value)
				{
					return;
				}
				_revealPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("revealPlayerOutsideSecurityPerimeter")] 
		public CBool RevealPlayerOutsideSecurityPerimeter
		{
			get
			{
				if (_revealPlayerOutsideSecurityPerimeter == null)
				{
					_revealPlayerOutsideSecurityPerimeter = (CBool) CR2WTypeManager.Create("Bool", "revealPlayerOutsideSecurityPerimeter", cr2w, this);
				}
				return _revealPlayerOutsideSecurityPerimeter;
			}
			set
			{
				if (_revealPlayerOutsideSecurityPerimeter == value)
				{
					return;
				}
				_revealPlayerOutsideSecurityPerimeter = value;
				PropertySet(this);
			}
		}

		public RevealPlayerSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
