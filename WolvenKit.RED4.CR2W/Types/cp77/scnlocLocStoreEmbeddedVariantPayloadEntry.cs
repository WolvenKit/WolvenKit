using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbeddedVariantPayloadEntry : CVariable
	{
		private scnlocVariantId _variantId;
		private CString _content;

		[Ordinal(0)] 
		[RED("variantId")] 
		public scnlocVariantId VariantId
		{
			get => GetProperty(ref _variantId);
			set => SetProperty(ref _variantId, value);
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CString Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		public scnlocLocStoreEmbeddedVariantPayloadEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
