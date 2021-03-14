using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocLocStoreEmbedded : CVariable
	{
		private CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> _vdEntries;
		private CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> _vpEntries;

		[Ordinal(0)] 
		[RED("vdEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry> VdEntries
		{
			get
			{
				if (_vdEntries == null)
				{
					_vdEntries = (CArray<scnlocLocStoreEmbeddedVariantDescriptorEntry>) CR2WTypeManager.Create("array:scnlocLocStoreEmbeddedVariantDescriptorEntry", "vdEntries", cr2w, this);
				}
				return _vdEntries;
			}
			set
			{
				if (_vdEntries == value)
				{
					return;
				}
				_vdEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vpEntries")] 
		public CArray<scnlocLocStoreEmbeddedVariantPayloadEntry> VpEntries
		{
			get
			{
				if (_vpEntries == null)
				{
					_vpEntries = (CArray<scnlocLocStoreEmbeddedVariantPayloadEntry>) CR2WTypeManager.Create("array:scnlocLocStoreEmbeddedVariantPayloadEntry", "vpEntries", cr2w, this);
				}
				return _vpEntries;
			}
			set
			{
				if (_vpEntries == value)
				{
					return;
				}
				_vpEntries = value;
				PropertySet(this);
			}
		}

		public scnlocLocStoreEmbedded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
