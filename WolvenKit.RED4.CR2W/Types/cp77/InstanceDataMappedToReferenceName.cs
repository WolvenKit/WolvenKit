using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstanceDataMappedToReferenceName : CVariable
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

		public InstanceDataMappedToReferenceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
