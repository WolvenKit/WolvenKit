using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnTimedCondition : ISerializable
	{
		private scnSceneTime _duration;
		private CEnum<scnChoiceNodeNsTimedAction> _action;
		private CBool _timeLimitedFinish;

		[Ordinal(0)] 
		[RED("duration")] 
		public scnSceneTime Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<scnChoiceNodeNsTimedAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(2)] 
		[RED("timeLimitedFinish")] 
		public CBool TimeLimitedFinish
		{
			get => GetProperty(ref _timeLimitedFinish);
			set => SetProperty(ref _timeLimitedFinish, value);
		}

		public scnTimedCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
