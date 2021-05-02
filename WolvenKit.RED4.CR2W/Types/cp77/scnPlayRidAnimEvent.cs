using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayRidAnimEvent : scnPlayFPPControlAnimEvent
	{
		private CUInt32 _ridVersinon;
		private scnRidAnimationSRRefId _animResRefId;
		private scnMarker _animOriginMarker;
		private CEnum<scnRidActorPlacement> _actorPlacement;
		private CBool _actorHasCollision;
		private CFloat _blendInTrajectoryBone;

		[Ordinal(31)] 
		[RED("ridVersinon")] 
		public CUInt32 RidVersinon
		{
			get => GetProperty(ref _ridVersinon);
			set => SetProperty(ref _ridVersinon, value);
		}

		[Ordinal(32)] 
		[RED("animResRefId")] 
		public scnRidAnimationSRRefId AnimResRefId
		{
			get => GetProperty(ref _animResRefId);
			set => SetProperty(ref _animResRefId, value);
		}

		[Ordinal(33)] 
		[RED("animOriginMarker")] 
		public scnMarker AnimOriginMarker
		{
			get => GetProperty(ref _animOriginMarker);
			set => SetProperty(ref _animOriginMarker, value);
		}

		[Ordinal(34)] 
		[RED("actorPlacement")] 
		public CEnum<scnRidActorPlacement> ActorPlacement
		{
			get => GetProperty(ref _actorPlacement);
			set => SetProperty(ref _actorPlacement, value);
		}

		[Ordinal(35)] 
		[RED("actorHasCollision")] 
		public CBool ActorHasCollision
		{
			get => GetProperty(ref _actorHasCollision);
			set => SetProperty(ref _actorHasCollision, value);
		}

		[Ordinal(36)] 
		[RED("blendInTrajectoryBone")] 
		public CFloat BlendInTrajectoryBone
		{
			get => GetProperty(ref _blendInTrajectoryBone);
			set => SetProperty(ref _blendInTrajectoryBone, value);
		}

		public scnPlayRidAnimEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
