using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstanceDataMappedToReferenceName : CVariable
	{
		[Ordinal(0)] [RED("itemHandlingFeatureName")] public CName ItemHandlingFeatureName { get; set; }
		[Ordinal(1)] [RED("attachmentSlot")] public CString AttachmentSlot { get; set; }

		public InstanceDataMappedToReferenceName(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
