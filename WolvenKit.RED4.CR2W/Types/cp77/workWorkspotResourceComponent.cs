using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResourceComponent : entIPlacedComponent
	{
		private raRef<workWorkspotResource> _workspotResource;
		private rRef<workWorkspotResource> _npcWorkspotResourceSync;
		private rRef<workWorkspotResource> _deviceWorkspotResourceSync;
		private CName _syncSlotName;
		private CBool _shouldCrouch;

		[Ordinal(5)] 
		[RED("workspotResource")] 
		public raRef<workWorkspotResource> WorkspotResource
		{
			get => GetProperty(ref _workspotResource);
			set => SetProperty(ref _workspotResource, value);
		}

		[Ordinal(6)] 
		[RED("npcWorkspotResourceSync")] 
		public rRef<workWorkspotResource> NpcWorkspotResourceSync
		{
			get => GetProperty(ref _npcWorkspotResourceSync);
			set => SetProperty(ref _npcWorkspotResourceSync, value);
		}

		[Ordinal(7)] 
		[RED("deviceWorkspotResourceSync")] 
		public rRef<workWorkspotResource> DeviceWorkspotResourceSync
		{
			get => GetProperty(ref _deviceWorkspotResourceSync);
			set => SetProperty(ref _deviceWorkspotResourceSync, value);
		}

		[Ordinal(8)] 
		[RED("syncSlotName")] 
		public CName SyncSlotName
		{
			get => GetProperty(ref _syncSlotName);
			set => SetProperty(ref _syncSlotName, value);
		}

		[Ordinal(9)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get => GetProperty(ref _shouldCrouch);
			set => SetProperty(ref _shouldCrouch, value);
		}

		public workWorkspotResourceComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
