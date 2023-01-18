using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DismembermentEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetPropertyValue<CEnum<gameDismBodyPart>>();
			set => SetPropertyValue<CEnum<gameDismBodyPart>>(value);
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CEnum<gameDismWoundType> WoundType
		{
			get => GetPropertyValue<CEnum<gameDismWoundType>>();
			set => SetPropertyValue<CEnum<gameDismWoundType>>(value);
		}

		[Ordinal(2)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("debrisPath")] 
		public CString DebrisPath
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("debrisStrength")] 
		public CFloat DebrisStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DismembermentEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
