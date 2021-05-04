using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetChargedThrowEvents : CombatGadgetTransitions
	{
		private CBool _grenadeThrown;
		private Vector4 _localAimForward;
		private Vector4 _localAimPosition;

		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetProperty(ref _grenadeThrown);
			set => SetProperty(ref _grenadeThrown, value);
		}

		[Ordinal(1)] 
		[RED("localAimForward")] 
		public Vector4 LocalAimForward
		{
			get => GetProperty(ref _localAimForward);
			set => SetProperty(ref _localAimForward, value);
		}

		[Ordinal(2)] 
		[RED("localAimPosition")] 
		public Vector4 LocalAimPosition
		{
			get => GetProperty(ref _localAimPosition);
			set => SetProperty(ref _localAimPosition, value);
		}

		public CombatGadgetChargedThrowEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
