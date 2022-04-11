using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workWorkspotResourceComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("workspotResource")] 
		public CResourceAsyncReference<workWorkspotResource> WorkspotResource
		{
			get => GetPropertyValue<CResourceAsyncReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceAsyncReference<workWorkspotResource>>(value);
		}

		[Ordinal(6)] 
		[RED("npcWorkspotResourceSync")] 
		public CResourceReference<workWorkspotResource> NpcWorkspotResourceSync
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		[Ordinal(7)] 
		[RED("deviceWorkspotResourceSync")] 
		public CResourceReference<workWorkspotResource> DeviceWorkspotResourceSync
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		[Ordinal(8)] 
		[RED("syncSlotName")] 
		public CName SyncSlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("shouldCrouch")] 
		public CBool ShouldCrouch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public workWorkspotResourceComponent()
		{
			Name = "Component";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
		}
	}
}
