using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIApproachingAreaEvent : AIAIEvent
	{
		private CBool _isApproachCancellation;
		private wCHandle<gameStaticAreaShapeComponent> _areaComponent;
		private wCHandle<entEntity> _responseTarget;

		[Ordinal(2)] 
		[RED("isApproachCancellation")] 
		public CBool IsApproachCancellation
		{
			get => GetProperty(ref _isApproachCancellation);
			set => SetProperty(ref _isApproachCancellation, value);
		}

		[Ordinal(3)] 
		[RED("areaComponent")] 
		public wCHandle<gameStaticAreaShapeComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(4)] 
		[RED("responseTarget")] 
		public wCHandle<entEntity> ResponseTarget
		{
			get => GetProperty(ref _responseTarget);
			set => SetProperty(ref _responseTarget, value);
		}

		public AIApproachingAreaEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
