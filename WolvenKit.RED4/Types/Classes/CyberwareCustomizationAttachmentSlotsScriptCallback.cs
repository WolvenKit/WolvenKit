using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareCustomizationAttachmentSlotsScriptCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("cyberwareCustomizationSystem")] 
		public CWeakHandle<CyberwareCustomizationSystem> CyberwareCustomizationSystem
		{
			get => GetPropertyValue<CWeakHandle<CyberwareCustomizationSystem>>();
			set => SetPropertyValue<CWeakHandle<CyberwareCustomizationSystem>>(value);
		}

		public CyberwareCustomizationAttachmentSlotsScriptCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
