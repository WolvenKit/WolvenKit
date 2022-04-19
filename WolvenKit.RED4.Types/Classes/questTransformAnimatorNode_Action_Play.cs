using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTransformAnimatorNode_Action_Play : questTransformAnimatorNode_ActionType
	{
		[Ordinal(0)] 
		[RED("timesPlayed")] 
		public CInt32 TimesPlayed
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("useEntitySetup")] 
		public CBool UseEntitySetup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questTransformAnimatorNode_Action_Play()
		{
			TimesPlayed = -1;
			TimeScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
