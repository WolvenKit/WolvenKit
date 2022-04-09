using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("checkStimType")] 
		public CBool CheckStimType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("stimType")] 
		public CEnum<gamedataStimType> StimType
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}

		public CheckStimRevealsInstigatorPosition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
