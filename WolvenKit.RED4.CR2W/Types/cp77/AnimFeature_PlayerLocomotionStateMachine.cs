using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerLocomotionStateMachine : animAnimFeature
	{
		private CBool _inAirState;

		[Ordinal(0)] 
		[RED("inAirState")] 
		public CBool InAirState
		{
			get => GetProperty(ref _inAirState);
			set => SetProperty(ref _inAirState, value);
		}

		public AnimFeature_PlayerLocomotionStateMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
