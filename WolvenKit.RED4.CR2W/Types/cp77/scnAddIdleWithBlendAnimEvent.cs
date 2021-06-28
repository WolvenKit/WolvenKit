using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAddIdleWithBlendAnimEvent : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private CName _actorComponent;
		private CFloat _targetWeight;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get => GetProperty(ref _actorComponent);
			set => SetProperty(ref _actorComponent, value);
		}

		[Ordinal(8)] 
		[RED("targetWeight")] 
		public CFloat TargetWeight
		{
			get => GetProperty(ref _targetWeight);
			set => SetProperty(ref _targetWeight, value);
		}

		public scnAddIdleWithBlendAnimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
