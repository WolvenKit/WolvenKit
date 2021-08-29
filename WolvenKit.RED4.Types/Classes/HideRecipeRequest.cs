using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HideRecipeRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _recipe;

		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetProperty(ref _recipe);
			set => SetProperty(ref _recipe, value);
		}
	}
}
