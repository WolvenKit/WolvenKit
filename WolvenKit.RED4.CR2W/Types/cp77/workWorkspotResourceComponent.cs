using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotResourceComponent : entIPlacedComponent
	{
		private rRef<workWorkspotResource> _resource;
		private rRef<workWorkspotResource> _npcResource;
		private rRef<workWorkspotResource> _deviceResource;
		private CName _syncSlotName;
		private CBool _shouldCrouch;

		[Ordinal(5)] 
		[RED("resource")] 
		public rRef<workWorkspotResource> Resource
		{
			get => GetProperty(ref _resource);
			set => SetProperty(ref _resource, value);
		}

		[Ordinal(6)] 
		[RED("npcResource")] 
		public rRef<workWorkspotResource> NpcResource
		{
			get => GetProperty(ref _npcResource);
			set => SetProperty(ref _npcResource, value);
		}

		[Ordinal(7)] 
		[RED("deviceResource")] 
		public rRef<workWorkspotResource> DeviceResource
		{
			get => GetProperty(ref _deviceResource);
			set => SetProperty(ref _deviceResource, value);
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
