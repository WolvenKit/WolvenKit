using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShowRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
