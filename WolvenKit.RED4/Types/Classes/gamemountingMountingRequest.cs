using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingMountingRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("lowLevelMountingInfo")] 
		public gamemountingMountingInfo LowLevelMountingInfo
		{
			get => GetPropertyValue<gamemountingMountingInfo>();
			set => SetPropertyValue<gamemountingMountingInfo>(value);
		}

		[Ordinal(1)] 
		[RED("preservePositionAfterMounting")] 
		public CBool PreservePositionAfterMounting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetPropertyValue<CHandle<gameMountEventData>>();
			set => SetPropertyValue<CHandle<gameMountEventData>>(value);
		}

		public gamemountingMountingRequest()
		{
			LowLevelMountingInfo = new gamemountingMountingInfo { ChildId = new entEntityID(), ParentId = new entEntityID(), SlotId = new gamemountingMountingSlotId() };
			PreservePositionAfterMounting = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
