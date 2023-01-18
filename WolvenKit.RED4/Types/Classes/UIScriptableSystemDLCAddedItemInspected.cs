using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemDLCAddedItemInspected : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public UIScriptableSystemDLCAddedItemInspected()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
