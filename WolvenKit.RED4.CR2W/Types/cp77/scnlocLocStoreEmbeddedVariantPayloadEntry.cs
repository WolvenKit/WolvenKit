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
			get
			{
				if (_variantId == null)
				{
					_variantId = (scnlocVariantId) CR2WTypeManager.Create("scnlocVariantId", "variantId", cr2w, this);
				}
				return _variantId;
			}
			set
			{
				if (_variantId == value)
				{
					return;
				}
				_variantId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("content")] 
		public CString Content
		{
			get
			{
				if (_content == null)
				{
					_content = (CString) CR2WTypeManager.Create("String", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		public scnlocLocStoreEmbeddedVariantPayloadEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
