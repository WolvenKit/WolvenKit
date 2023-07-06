using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectTriggerEffectDesc : ISerializable
	{
		[Ordinal(0)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetPropertyValue<CResourceAsyncReference<worldEffect>>();
			set => SetPropertyValue<CResourceAsyncReference<worldEffect>>(value);
		}

		[Ordinal(1)] 
		[RED("positionType")] 
		public CEnum<gameEffectTriggerPositioningType> PositionType
		{
			get => GetPropertyValue<CEnum<gameEffectTriggerPositioningType>>();
			set => SetPropertyValue<CEnum<gameEffectTriggerPositioningType>>(value);
		}

		[Ordinal(2)] 
		[RED("rotationType")] 
		public CEnum<gameEffectTriggerRotationType> RotationType
		{
			get => GetPropertyValue<CEnum<gameEffectTriggerRotationType>>();
			set => SetPropertyValue<CEnum<gameEffectTriggerRotationType>>(value);
		}

		[Ordinal(3)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(4)] 
		[RED("playFromHour")] 
		public CUInt32 PlayFromHour
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("playTillHour")] 
		public CUInt32 PlayTillHour
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameEffectTriggerEffectDesc()
		{
			Offset = new Vector3();
			PlayTillHour = 24;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
