using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeMenuListItemData : ListItemData
	{
		private CUInt32 _attributeKey;

		[Ordinal(1)] 
		[RED("attributeKey")] 
		public CUInt32 AttributeKey
		{
			get
			{
				if (_attributeKey == null)
				{
					_attributeKey = (CUInt32) CR2WTypeManager.Create("Uint32", "attributeKey", cr2w, this);
				}
				return _attributeKey;
			}
			set
			{
				if (_attributeKey == value)
				{
					return;
				}
				_attributeKey = value;
				PropertySet(this);
			}
		}

		public PhotoModeMenuListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
