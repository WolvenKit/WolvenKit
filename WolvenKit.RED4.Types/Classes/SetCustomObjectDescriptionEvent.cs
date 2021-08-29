using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetCustomObjectDescriptionEvent : redEvent
	{
		private CHandle<ObjectScanningDescription> _objectDescription;

		[Ordinal(0)] 
		[RED("objectDescription")] 
		public CHandle<ObjectScanningDescription> ObjectDescription
		{
			get => GetProperty(ref _objectDescription);
			set => SetProperty(ref _objectDescription, value);
		}
	}
}
