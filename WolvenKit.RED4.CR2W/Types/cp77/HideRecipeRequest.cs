using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HideRecipeRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _recipe;

		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get
			{
				if (_recipe == null)
				{
					_recipe = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recipe", cr2w, this);
				}
				return _recipe;
			}
			set
			{
				if (_recipe == value)
				{
					return;
				}
				_recipe = value;
				PropertySet(this);
			}
		}

		public HideRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
