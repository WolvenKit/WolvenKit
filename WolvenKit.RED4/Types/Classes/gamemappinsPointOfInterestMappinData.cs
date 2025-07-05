using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get => GetPropertyValue<CHandle<gamemappinsIPointOfInterestVariant>>();
			set => SetPropertyValue<CHandle<gamemappinsIPointOfInterestVariant>>(value);
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("slotOffset")] 
		public Vector3 SlotOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("dynamicMappinRadius")] 
		public CFloat DynamicMappinRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("staticMappinDef")] 
		public TweakDBID StaticMappinDef
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(6)] 
		[RED("dynamicMappinDef")] 
		public TweakDBID DynamicMappinDef
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gamemappinsPointOfInterestMappinData()
		{
			Active = true;
			SlotName = "UI_Interaction";
			SlotOffset = new Vector3 { Z = 0.500000F };
			DynamicMappinRadius = 30.000000F;
			StaticMappinDef = "Mappins.StaticPointOfInterestMappinDefinition";
			DynamicMappinDef = "Mappins.DynamicPointOfInterestMappinDefinition";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
