using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerDoesntHaveRecipePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("recipeID")] 
		public TweakDBID RecipeID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerDoesntHaveRecipePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
