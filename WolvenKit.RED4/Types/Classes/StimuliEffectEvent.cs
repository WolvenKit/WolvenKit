using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimuliEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("stimuliEventName")] 
		public CName StimuliEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public StimuliEffectEvent()
		{
			TargetPoint = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
