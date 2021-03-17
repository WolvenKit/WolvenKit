using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameOccupantSlotData : CVariable
	{
		private CName _slotName;
		private CName _syncAnimationTag;
		private rRef<workWorkspotResource> _workSpotResource;
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
		public rRef<workWorkspotResource> WorkSpotResource
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

		public gameOccupantSlotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
