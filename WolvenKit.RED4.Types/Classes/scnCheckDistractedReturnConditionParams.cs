using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckDistractedReturnConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("distracted")] 
		public CBool Distracted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CEnum<scnDistractedConditionTarget> Target
		{
			get => GetPropertyValue<CEnum<scnDistractedConditionTarget>>();
			set => SetPropertyValue<CEnum<scnDistractedConditionTarget>>(value);
		}

		public scnCheckDistractedReturnConditionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
