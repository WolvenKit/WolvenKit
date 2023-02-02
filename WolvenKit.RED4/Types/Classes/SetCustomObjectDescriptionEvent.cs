using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetCustomObjectDescriptionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get => GetPropertyValue<CHandle<ObjectScanningDescription>>();
			set => SetPropertyValue<CHandle<ObjectScanningDescription>>(value);
		}

		public SetCustomObjectDescriptionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
