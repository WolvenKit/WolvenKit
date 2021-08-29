using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkComboBoxObjectController : inkWidgetLogicController
	{
		private inkWidgetReference _contentWidgetRef;
		private inkWidgetReference _placeholderOffsetWidgetRef;
		private inkShapeWidgetReference _colliderRef;
		private inkMargin _offset;

		[Ordinal(1)] 
		[RED("contentWidgetRef")] 
		public inkWidgetReference ContentWidgetRef
		{
			get => GetProperty(ref _contentWidgetRef);
			set => SetProperty(ref _contentWidgetRef, value);
		}

		[Ordinal(2)] 
		[RED("placeholderOffsetWidgetRef")] 
		public inkWidgetReference PlaceholderOffsetWidgetRef
		{
			get => GetProperty(ref _placeholderOffsetWidgetRef);
			set => SetProperty(ref _placeholderOffsetWidgetRef, value);
		}

		[Ordinal(3)] 
		[RED("colliderRef")] 
		public inkShapeWidgetReference ColliderRef
		{
			get => GetProperty(ref _colliderRef);
			set => SetProperty(ref _colliderRef, value);
		}

		[Ordinal(4)] 
		[RED("offset")] 
		public inkMargin Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
