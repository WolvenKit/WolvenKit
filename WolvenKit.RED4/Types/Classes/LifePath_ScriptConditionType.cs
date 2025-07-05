using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LifePath_ScriptConditionType : BluelineConditionTypeBase
	{
		[Ordinal(0)] 
		[RED("lifePathId")] 
		public TweakDBID LifePathId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LifePath_ScriptConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
