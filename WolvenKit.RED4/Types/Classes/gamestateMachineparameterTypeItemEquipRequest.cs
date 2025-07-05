using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeItemEquipRequest : IScriptable
	{
		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("startingRenderingPlane")] 
		public CEnum<ERenderingPlane> StartingRenderingPlane
		{
			get => GetPropertyValue<CEnum<ERenderingPlane>>();
			set => SetPropertyValue<CEnum<ERenderingPlane>>(value);
		}

		public gamestateMachineparameterTypeItemEquipRequest()
		{
			ItemId = new gameItemID();
			StartingRenderingPlane = Enums.ERenderingPlane.RPl_Weapon;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
