using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShowRecipeRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _recipe;

		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetProperty(ref _recipe);
			set => SetProperty(ref _recipe, value);
		}

		public ShowRecipeRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
