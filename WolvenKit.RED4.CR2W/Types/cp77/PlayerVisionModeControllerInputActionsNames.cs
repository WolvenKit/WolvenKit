using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActionsNames : CVariable
	{
		private CName _buttonHold;
		private CName _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CName ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CName ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}

		public PlayerVisionModeControllerInputActionsNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
