using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		private CBool _soloModeState;

		[Ordinal(5)] 
		[RED("soloModeState")] 
		public CBool SoloModeState
		{
			get
			{
				if (_soloModeState == null)
				{
					_soloModeState = (CBool) CR2WTypeManager.Create("Bool", "soloModeState", cr2w, this);
				}
				return _soloModeState;
			}
			set
			{
				if (_soloModeState == value)
				{
					return;
				}
				_soloModeState = value;
				PropertySet(this);
			}
		}

		public AIFlatheadSetSoloModeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
