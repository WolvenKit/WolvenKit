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

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hideOnItemsAdded")] 
		public CArray<wCHandle<gamedataItem_Record>> HideOnItemsAdded
		{
			get
			{
				if (_hideOnItemsAdded == null)
				{
					_hideOnItemsAdded = (CArray<wCHandle<gamedataItem_Record>>) CR2WTypeManager.Create("array:whandle:gamedataItem_Record", "hideOnItemsAdded", cr2w, this);
				}
				return _hideOnItemsAdded;
			}
			set
			{
				if (_hideOnItemsAdded == value)
				{
					return;
				}
				_hideOnItemsAdded = value;
				PropertySet(this);
			}
		}

		public AddRecipeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
