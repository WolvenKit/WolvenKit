using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayDefaultMountedSlotWorkspotEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private gameEntityReference _parentRef;
		private CName _slotName;
		private CEnum<scnPuppetVehicleState> _puppetVehicleState;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetProperty(ref _parentRef);
			set => SetProperty(ref _parentRef, value);
		}

		[Ordinal(8)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(9)] 
		[RED("puppetVehicleState")] 
		public CEnum<scnPuppetVehicleState> PuppetVehicleState
		{
			get => GetProperty(ref _puppetVehicleState);
			set => SetProperty(ref _puppetVehicleState, value);
		}

		public scnPlayDefaultMountedSlotWorkspotEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
