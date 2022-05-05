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

		public gamemountingUnmountingRequest()
		{
			LowLevelMountingInfo = new() { ChildId = new(), ParentId = new(), SlotId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
