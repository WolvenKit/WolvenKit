using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestDismembermentEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetPropertyValue<CEnum<gameDismBodyPart>>();
			set => SetPropertyValue<CEnum<gameDismBodyPart>>(value);
		}

		[Ordinal(3)] 
		[RED("dismembermentType")] 
		public CEnum<gameDismWoundType> DismembermentType
		{
			get => GetPropertyValue<CEnum<gameDismWoundType>>();
			set => SetPropertyValue<CEnum<gameDismWoundType>>(value);
		}

		[Ordinal(4)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RequestDismembermentEvent()
		{
			HitPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
