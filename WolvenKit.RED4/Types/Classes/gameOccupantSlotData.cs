using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameOccupantSlotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("syncAnimationTag")] 
		public CName SyncAnimationTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("workSpotResource")] 
		public CResourceReference<workWorkspotResource> WorkSpotResource
		{
			get => GetPropertyValue<CResourceReference<workWorkspotResource>>();
			set => SetPropertyValue<CResourceReference<workWorkspotResource>>(value);
		}

		[Ordinal(3)] 
		[RED("exitOffsetFromSlot")] 
		public Vector4 ExitOffsetFromSlot
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetPropertyValue<CEnum<gameMountingSlotRole>>();
			set => SetPropertyValue<CEnum<gameMountingSlotRole>>(value);
		}

		public gameOccupantSlotData()
		{
			ExitOffsetFromSlot = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
