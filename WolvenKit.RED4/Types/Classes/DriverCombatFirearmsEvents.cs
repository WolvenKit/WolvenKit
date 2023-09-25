using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DriverCombatFirearmsEvents : DriverCombatEvents
	{
		[Ordinal(20)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		[Ordinal(21)] 
		[RED("posAnimFeature")] 
		public CHandle<AnimFeature_ProceduralDriverCombatData> PosAnimFeature
		{
			get => GetPropertyValue<CHandle<AnimFeature_ProceduralDriverCombatData>>();
			set => SetPropertyValue<CHandle<AnimFeature_ProceduralDriverCombatData>>(value);
		}

		[Ordinal(22)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetPropertyValue<CHandle<gamedataVehicle_Record>>();
			set => SetPropertyValue<CHandle<gamedataVehicle_Record>>(value);
		}

		[Ordinal(23)] 
		[RED("angleDelta")] 
		public EulerAngles AngleDelta
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(24)] 
		[RED("localOrientation")] 
		public EulerAngles LocalOrientation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		[Ordinal(25)] 
		[RED("updateItemType")] 
		public CEnum<gamedataItemType> UpdateItemType
		{
			get => GetPropertyValue<CEnum<gamedataItemType>>();
			set => SetPropertyValue<CEnum<gamedataItemType>>(value);
		}

		[Ordinal(26)] 
		[RED("minSwaySpeed")] 
		public CFloat MinSwaySpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("prevSpeed")] 
		public CFloat PrevSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DriverCombatFirearmsEvents()
		{
			AngleDelta = new EulerAngles();
			LocalOrientation = new EulerAngles();
			MinSwaySpeed = 0.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
