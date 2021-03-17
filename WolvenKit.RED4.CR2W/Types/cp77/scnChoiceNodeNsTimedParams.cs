using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsTimedParams : ISerializable
	{
		private CEnum<scnChoiceNodeNsTimedAction> _action;
		private CBool _timeLimitedFinish;
		private scnSceneTime _duration;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get => GetProperty(ref _timeLimitedFinish);
			set => SetProperty(ref _timeLimitedFinish, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public scnChoiceNodeNsTimedParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
