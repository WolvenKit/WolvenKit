using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UnlockMinigameProgramEffector : gameEffector
	{
		private gameuiMinigameProgramData _minigameProgram;

		[Ordinal(0)] 
		[RED("minigameProgram")] 
		public gameuiMinigameProgramData MinigameProgram
		{
			get
			{
				if (_minigameProgram == null)
				{
					_minigameProgram = (gameuiMinigameProgramData) CR2WTypeManager.Create("gameuiMinigameProgramData", "minigameProgram", cr2w, this);
				}
				return _minigameProgram;
			}
			set
			{
				if (_minigameProgram == value)
				{
					return;
				}
				_minigameProgram = value;
				PropertySet(this);
			}
		}

		public UnlockMinigameProgramEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
