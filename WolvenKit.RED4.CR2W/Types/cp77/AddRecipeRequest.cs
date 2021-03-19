using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _recipe;
		private CInt32 _amount;
		private CArray<wCHandle<gamedataItem_Record>> _hideOnItemsAdded;

		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetProperty(ref _recipe);
			set => SetProperty(ref _recipe, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(3)] 
		[RED("hideOnItemsAdded")] 
		public CArray<wCHandle<gamedataItem_Record>> HideOnItemsAdded
		{
			get => GetProperty(ref _hideOnItemsAdded);
			set => SetProperty(ref _hideOnItemsAdded, value);
		}

		public AddRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
