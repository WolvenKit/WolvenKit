using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_TranslationAffectedAxis : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("X")] 
		public CBool X
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CBool Y
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public CBool Z
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public cameraShotEffect_TranslationAffectedAxis()
		{
			X = true;
			Y = true;
			Z = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
