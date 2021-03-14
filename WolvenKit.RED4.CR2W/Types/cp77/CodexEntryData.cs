using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexEntryData : GenericCodexEntryData
	{
		private CInt32 _category;
		private CEnum<CodexImageType> _imageType;

		[Ordinal(10)] 
		[RED("category")] 
		public CInt32 Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CInt32) CR2WTypeManager.Create("Int32", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("imageType")] 
		public CEnum<CodexImageType> ImageType
		{
			get
			{
				if (_imageType == null)
				{
					_imageType = (CEnum<CodexImageType>) CR2WTypeManager.Create("CodexImageType", "imageType", cr2w, this);
				}
				return _imageType;
			}
			set
			{
				if (_imageType == value)
				{
					return;
				}
				_imageType = value;
				PropertySet(this);
			}
		}

		public CodexEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
