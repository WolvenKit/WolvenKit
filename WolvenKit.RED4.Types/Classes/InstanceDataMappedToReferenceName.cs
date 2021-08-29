using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InstanceDataMappedToReferenceName : RedBaseClass
	{
		private CName _itemHandlingFeatureName;
		private CString _attachmentSlot;

		[Ordinal(0)] 
		[RED("itemHandlingFeatureName")] 
		public CName ItemHandlingFeatureName
		{
			get => GetProperty(ref _itemHandlingFeatureName);
			set => SetProperty(ref _itemHandlingFeatureName, value);
		}

		[Ordinal(1)] 
		[RED("attachmentSlot")] 
		public CString AttachmentSlot
		{
			get => GetProperty(ref _attachmentSlot);
			set => SetProperty(ref _attachmentSlot, value);
		}
	}
}
