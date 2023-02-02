using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CraftBook : IScriptable
	{
		[Ordinal(0)] 
		[RED("knownRecipes")] 
		public CArray<ItemRecipe> KnownRecipes
		{
			get => GetPropertyValue<CArray<ItemRecipe>>();
			set => SetPropertyValue<CArray<ItemRecipe>>(value);
		}

		[Ordinal(1)] 
		[RED("newRecipes")] 
		public CArray<TweakDBID> NewRecipes
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CraftBook()
		{
			KnownRecipes = new();
			NewRecipes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
