using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HideRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public HideRecipeRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
