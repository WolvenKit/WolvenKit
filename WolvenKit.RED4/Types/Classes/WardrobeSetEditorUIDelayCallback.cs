using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WardrobeSetEditorUIDelayCallback : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<WardrobeSetEditorUIController> Owner
		{
			get => GetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>();
			set => SetPropertyValue<CWeakHandle<WardrobeSetEditorUIController>>(value);
		}

		public WardrobeSetEditorUIDelayCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
