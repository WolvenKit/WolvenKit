using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotResourceComponent : entIPlacedComponent
	{
		private CResourceAsyncReference<workWorkspotResource> _workspotResource;
		private CResourceReference<workWorkspotResource> _npcWorkspotResourceSync;
		private CResourceReference<workWorkspotResource> _deviceWorkspotResourceSync;
		private CName _syncSlotName;
		private CBool _shouldCrouch;

		[Ordinal(5)] 
		[RED("workspotResource")] 
		public CResourceAsyncReference<workWorkspotResource> WorkspotResource
		{
			get => GetProperty(ref _workspotResource);
			set => SetProperty(ref _workspotResource, value);
		}

		[Ordinal(6)] 
		[RED("npcWorkspotResourceSync")] 
		public CResourceReference<workWorkspotResource> NpcWorkspotResourceSync
		{
			get => GetProperty(ref _npcWorkspotResourceSync);
			set => SetProperty(ref _npcWorkspotResourceSync, value);
		}

		[Ordinal(7)] 
		[RED("deviceWorkspotResourceSync")] 
		public CResourceReference<workWorkspotResource> DeviceWorkspotResourceSync
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
	}
}
