using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputListeners : CVariable
	{
		private CUInt32 _buttonHold;
		private CUInt32 _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CUInt32 ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CUInt32 ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}

		public PlayerVisionModeControllerInputListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
