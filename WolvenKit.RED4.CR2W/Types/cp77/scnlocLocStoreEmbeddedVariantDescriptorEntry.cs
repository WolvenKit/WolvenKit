using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbeddedVariantDescriptorEntry : CVariable
	{
		private scnlocVariantId _variantId;
		private scnlocLocstringId _locstringId;
		private CEnum<scnlocLocaleId> _localeId;
		private scnlocSignature _signature;
		private CUInt32 _vpeIndex;

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
		[RED("locstringId")] 
		public scnlocLocstringId LocstringId
		{
			get
			{
				if (_locstringId == null)
				{
					_locstringId = (scnlocLocstringId) CR2WTypeManager.Create("scnlocLocstringId", "locstringId", cr2w, this);
				}
				return _locstringId;
			}
			set
			{
				if (_locstringId == value)
				{
					return;
				}
				_locstringId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localeId")] 
		public CEnum<scnlocLocaleId> LocaleId
		{
			get
			{
				if (_localeId == null)
				{
					_localeId = (CEnum<scnlocLocaleId>) CR2WTypeManager.Create("scnlocLocaleId", "localeId", cr2w, this);
				}
				return _localeId;
			}
			set
			{
				if (_localeId == value)
				{
					return;
				}
				_localeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("signature")] 
		public scnlocSignature Signature
		{
			get
			{
				if (_signature == null)
				{
					_signature = (scnlocSignature) CR2WTypeManager.Create("scnlocSignature", "signature", cr2w, this);
				}
				return _signature;
			}
			set
			{
				if (_signature == value)
				{
					return;
				}
				_signature = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("vpeIndex")] 
		public CUInt32 VpeIndex
		{
			get
			{
				if (_vpeIndex == null)
				{
					_vpeIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "vpeIndex", cr2w, this);
				}
				return _vpeIndex;
			}
			set
			{
				if (_vpeIndex == value)
				{
					return;
				}
				_vpeIndex = value;
				PropertySet(this);
			}
		}

		public scnlocLocStoreEmbeddedVariantDescriptorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
