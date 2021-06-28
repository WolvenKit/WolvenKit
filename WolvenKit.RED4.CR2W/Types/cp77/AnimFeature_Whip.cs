using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Whip : animAnimFeature
	{
		private CInt32 _state;
		private CInt32 _pullState;
		private Vector4 _targetPoint;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("pullState")] 
		public CInt32 PullState
		{
			get => GetProperty(ref _pullState);
			set => SetProperty(ref _pullState, value);
		}

		[Ordinal(2)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get => GetProperty(ref _targetPoint);
			set => SetProperty(ref _targetPoint, value);
		}

		public AnimFeature_Whip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
