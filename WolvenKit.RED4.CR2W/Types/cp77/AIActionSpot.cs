using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionSpot : AISmartSpot
	{
		private raRef<workWorkspotResource> _resource;
		private CEnum<AISocketsForRig> _actorBodytypeE3;
		private NodeRef _masterNodeRef;
		private CBool _enabledWhenMasterOccupied;
		private CBool _snapToGround;
		private CBool _useClippingSpace;
		private CFloat _clippingSpaceOrientation;
		private CFloat _clippingSpaceRange;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<workWorkspotResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(1)] 
		[RED("ActorBodytypeE3")] 
		public CEnum<AISocketsForRig> ActorBodytypeE3
		{
			get => GetProperty(ref _actorBodytypeE3);
			set => SetProperty(ref _actorBodytypeE3, value);
		}

		[Ordinal(2)] 
		[RED("masterNodeRef")] 
		public NodeRef MasterNodeRef
		{
			get => GetProperty(ref _masterNodeRef);
			set => SetProperty(ref _masterNodeRef, value);
		}

		[Ordinal(3)] 
		[RED("enabledWhenMasterOccupied")] 
		public CBool EnabledWhenMasterOccupied
		{
			get => GetProperty(ref _enabledWhenMasterOccupied);
			set => SetProperty(ref _enabledWhenMasterOccupied, value);
		}

		[Ordinal(4)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get => GetProperty(ref _snapToGround);
			set => SetProperty(ref _snapToGround, value);
		}

		[Ordinal(5)] 
		[RED("useClippingSpace")] 
		public CBool UseClippingSpace
		{
			get => GetProperty(ref _useClippingSpace);
			set => SetProperty(ref _useClippingSpace, value);
		}

		[Ordinal(6)] 
		[RED("clippingSpaceOrientation")] 
		public CFloat ClippingSpaceOrientation
		{
			get => GetProperty(ref _clippingSpaceOrientation);
			set => SetProperty(ref _clippingSpaceOrientation, value);
		}

		[Ordinal(7)] 
		[RED("clippingSpaceRange")] 
		public CFloat ClippingSpaceRange
		{
			get => GetProperty(ref _clippingSpaceRange);
			set => SetProperty(ref _clippingSpaceRange, value);
		}

		public AIActionSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
