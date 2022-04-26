using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InstanceDataMappedToReferenceName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemHandlingFeatureName")] 
		public CName ItemHandlingFeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("attachmentSlot")] 
		public CString AttachmentSlot
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public InstanceDataMappedToReferenceName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
