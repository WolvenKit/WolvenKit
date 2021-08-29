using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOccupantSlotData : RedBaseClass
	{
		private CName _slotName;
		private CName _syncAnimationTag;
		private CResourceReference<workWorkspotResource> _workSpotResource;
		private Vector4 _exitOffsetFromSlot;
		private CEnum<gameMountingSlotRole> _role;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("syncAnimationTag")] 
		public CName SyncAnimationTag
		{
			get => GetProperty(ref _syncAnimationTag);
			set => SetProperty(ref _syncAnimationTag, value);
		}

		[Ordinal(2)] 
		[RED("workSpotResource")] 
		public CResourceReference<workWorkspotResource> WorkSpotResource
		{
			get => GetProperty(ref _workSpotResource);
			set => SetProperty(ref _workSpotResource, value);
		}

		[Ordinal(3)] 
		[RED("exitOffsetFromSlot")] 
		public Vector4 ExitOffsetFromSlot
		{
			get => GetProperty(ref _exitOffsetFromSlot);
			set => SetProperty(ref _exitOffsetFromSlot, value);
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}
	}
}
