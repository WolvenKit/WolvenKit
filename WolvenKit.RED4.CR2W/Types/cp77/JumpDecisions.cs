using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JumpDecisions : LocomotionAirDecisions
	{
		private CBool _jumpPressed;

		[Ordinal(3)] 
		[RED("jumpPressed")] 
		public CBool JumpPressed
		{
			get => GetProperty(ref _jumpPressed);
			set => SetProperty(ref _jumpPressed, value);
		}

		public JumpDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
