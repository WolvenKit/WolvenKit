using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrenadeLvl4HackEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("grenadeChangeEntity")] 
		public CWeakHandle<gameObject> GrenadeChangeEntity
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("grenadeChangedListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> GrenadeChangedListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		public GrenadeLvl4HackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
