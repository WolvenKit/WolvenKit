using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerOtherVars : CVariable
	{
		private CBool _enabledByToggle;
		private CBool _active;

		[Ordinal(0)] 
		[RED("enabledByToggle")] 
		public CBool EnabledByToggle
		{
			get => GetProperty(ref _enabledByToggle);
			set => SetProperty(ref _enabledByToggle, value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public PlayerVisionModeControllerOtherVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
