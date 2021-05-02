using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerVitals : animAnimFeature
	{
		private CInt32 _state;
		private CFloat _stateDuration;

		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(1)] 
		[RED("stateDuration")] 
		public CFloat StateDuration
		{
			get => GetProperty(ref _stateDuration);
			set => SetProperty(ref _stateDuration, value);
		}

		public AnimFeature_PlayerVitals(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
