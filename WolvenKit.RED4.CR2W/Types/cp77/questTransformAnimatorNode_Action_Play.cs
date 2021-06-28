using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Play : questTransformAnimatorNode_ActionType
	{
		private CInt32 _timesPlayed;
		private CFloat _timeScale;
		private CBool _reverse;
		private CBool _useEntitySetup;

		[Ordinal(0)] 
		[RED("timesPlayed")] 
		public CInt32 TimesPlayed
		{
			get => GetProperty(ref _timesPlayed);
			set => SetProperty(ref _timesPlayed, value);
		}

		[Ordinal(1)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(2)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(3)] 
		[RED("useEntitySetup")] 
		public CBool UseEntitySetup
		{
			get => GetProperty(ref _useEntitySetup);
			set => SetProperty(ref _useEntitySetup, value);
		}

		public questTransformAnimatorNode_Action_Play(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
