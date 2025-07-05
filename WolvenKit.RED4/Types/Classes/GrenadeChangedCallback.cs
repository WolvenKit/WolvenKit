using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GrenadeChangedCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] 
		[RED("grenadeChangeEntity")] 
		public CWeakHandle<gameObject> GrenadeChangeEntity
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("grenadeChangeListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> GrenadeChangeListener
		{
			get => GetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>();
			set => SetPropertyValue<CHandle<gameAttachmentSlotsScriptListener>>(value);
		}

		public GrenadeChangedCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
