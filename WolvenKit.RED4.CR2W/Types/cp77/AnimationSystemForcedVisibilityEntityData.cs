using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationSystemForcedVisibilityEntityData : IScriptable
	{
		private wCHandle<AnimationSystemForcedVisibilityManager> _owner;
		private entEntityID _entityID;
		private CArray<CHandle<ForcedVisibilityInAnimSystemData>> _forcedVisibilityInAnimSystemRequests;
		private CArray<CHandle<ForcedVisibilityInAnimSystemData>> _delayedForcedVisibilityInAnimSystemRequests;
		private CBool _hasVisibilityForcedInAnimSystem;
		private CBool _hasVisibilityForcedOnlyInFrustumInAnimSystem;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<AnimationSystemForcedVisibilityManager> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetProperty(ref _entityID);
			set => SetProperty(ref _entityID, value);
		}

		[Ordinal(2)] 
		[RED("forcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> ForcedVisibilityInAnimSystemRequests
		{
			get => GetProperty(ref _forcedVisibilityInAnimSystemRequests);
			set => SetProperty(ref _forcedVisibilityInAnimSystemRequests, value);
		}

		[Ordinal(3)] 
		[RED("delayedForcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> DelayedForcedVisibilityInAnimSystemRequests
		{
			get => GetProperty(ref _delayedForcedVisibilityInAnimSystemRequests);
			set => SetProperty(ref _delayedForcedVisibilityInAnimSystemRequests, value);
		}

		[Ordinal(4)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get => GetProperty(ref _hasVisibilityForcedInAnimSystem);
			set => SetProperty(ref _hasVisibilityForcedInAnimSystem, value);
		}

		[Ordinal(5)] 
		[RED("hasVisibilityForcedOnlyInFrustumInAnimSystem")] 
		public CBool HasVisibilityForcedOnlyInFrustumInAnimSystem
		{
			get => GetProperty(ref _hasVisibilityForcedOnlyInFrustumInAnimSystem);
			set => SetProperty(ref _hasVisibilityForcedOnlyInFrustumInAnimSystem, value);
		}

		public AnimationSystemForcedVisibilityEntityData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
