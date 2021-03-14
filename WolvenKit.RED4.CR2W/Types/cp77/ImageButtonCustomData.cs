using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageButtonCustomData : WidgetCustomData
	{
		private CName _imageAtlasImageID;
		private CString _additionalText;

		[Ordinal(0)] 
		[RED("imageAtlasImageID")] 
		public CName ImageAtlasImageID
		{
			get
			{
				if (_imageAtlasImageID == null)
				{
					_imageAtlasImageID = (CName) CR2WTypeManager.Create("CName", "imageAtlasImageID", cr2w, this);
				}
				return _imageAtlasImageID;
			}
			set
			{
				if (_imageAtlasImageID == value)
				{
					return;
				}
				_imageAtlasImageID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additionalText")] 
		public CString AdditionalText
		{
			get
			{
				if (_additionalText == null)
				{
					_additionalText = (CString) CR2WTypeManager.Create("String", "additionalText", cr2w, this);
				}
				return _additionalText;
			}
			set
			{
				if (_additionalText == value)
				{
					return;
				}
				_additionalText = value;
				PropertySet(this);
			}
		}

		public ImageButtonCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
