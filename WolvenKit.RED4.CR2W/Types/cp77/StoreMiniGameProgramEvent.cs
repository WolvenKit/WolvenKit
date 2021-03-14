using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StoreMiniGameProgramEvent : redEvent
	{
		private gameuiMinigameProgramData _program;
		private CBool _add;

		[Ordinal(0)] 
		[RED("program")] 
		public gameuiMinigameProgramData Program
		{
			get
			{
				if (_program == null)
				{
					_program = (gameuiMinigameProgramData) CR2WTypeManager.Create("gameuiMinigameProgramData", "program", cr2w, this);
				}
				return _program;
			}
			set
			{
				if (_program == value)
				{
					return;
				}
				_program = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("add")] 
		public CBool Add
		{
			get
			{
				if (_add == null)
				{
					_add = (CBool) CR2WTypeManager.Create("Bool", "add", cr2w, this);
				}
				return _add;
			}
			set
			{
				if (_add == value)
				{
					return;
				}
				_add = value;
				PropertySet(this);
			}
		}

		public StoreMiniGameProgramEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
