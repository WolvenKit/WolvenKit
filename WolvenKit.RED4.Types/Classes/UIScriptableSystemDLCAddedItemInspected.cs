using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIScriptableSystemDLCAddedItemInspected : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
