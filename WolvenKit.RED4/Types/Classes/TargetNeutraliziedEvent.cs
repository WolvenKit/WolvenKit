using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetNeutraliziedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<ENeutralizeType> Type
		{
			get => GetPropertyValue<CEnum<ENeutralizeType>>();
			set => SetPropertyValue<CEnum<ENeutralizeType>>(value);
		}

		[Ordinal(1)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public TargetNeutraliziedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
