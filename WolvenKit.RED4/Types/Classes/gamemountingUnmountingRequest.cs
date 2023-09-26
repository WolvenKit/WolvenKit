using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemountingUnmountingRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("lowLevelMountingInfo")] 
		public gamemountingMountingInfo LowLevelMountingInfo
		{
			get => GetPropertyValue<gamemountingMountingInfo>();
			set => SetPropertyValue<gamemountingMountingInfo>(value);
		}

		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<gameMountEventData> MountData
		{
			get => GetPropertyValue<CHandle<gameMountEventData>>();
			set => SetPropertyValue<CHandle<gameMountEventData>>(value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamemountingUnmountingRequest()
		{
			LowLevelMountingInfo = new gamemountingMountingInfo { ChildId = new entEntityID(), ParentId = new entEntityID(), SlotId = new gamemountingMountingSlotId() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
