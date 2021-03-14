using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CraftBook : IScriptable
	{
		private CArray<ItemRecipe> _knownRecipes;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get
			{
				if (_knownRecipes == null)
				{
					_knownRecipes = (CArray<ItemRecipe>) CR2WTypeManager.Create("array:ItemRecipe", "knownRecipes", cr2w, this);
				}
				return _knownRecipes;
			}
			set
			{
				if (_knownRecipes == value)
				{
					return;
				}
				_knownRecipes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public CraftBook(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
