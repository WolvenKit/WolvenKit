using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleImageChanger : inkWidgetLogicController
	{
		private CName _imagePath;
		private CName _imageName_1;
		private CName _imageName_2;
		private wCHandle<inkImageWidget> _imageWidget;

		[Ordinal(1)] 
		[RED("imagePath")] 
		public CName ImagePath
		{
			get
			{
				if (_imagePath == null)
				{
					_imagePath = (CName) CR2WTypeManager.Create("CName", "imagePath", cr2w, this);
				}
				return _imagePath;
			}
			set
			{
				if (_imagePath == value)
				{
					return;
				}
				_imagePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("imageName_1")] 
		public CName ImageName_1
		{
			get
			{
				if (_imageName_1 == null)
				{
					_imageName_1 = (CName) CR2WTypeManager.Create("CName", "imageName_1", cr2w, this);
				}
				return _imageName_1;
			}
			set
			{
				if (_imageName_1 == value)
				{
					return;
				}
				_imageName_1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("imageName_2")] 
		public CName ImageName_2
		{
			get
			{
				if (_imageName_2 == null)
				{
					_imageName_2 = (CName) CR2WTypeManager.Create("CName", "imageName_2", cr2w, this);
				}
				return _imageName_2;
			}
			set
			{
				if (_imageName_2 == value)
				{
					return;
				}
				_imageName_2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("imageWidget")] 
		public wCHandle<inkImageWidget> ImageWidget
		{
			get
			{
				if (_imageWidget == null)
				{
					_imageWidget = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "imageWidget", cr2w, this);
				}
				return _imageWidget;
			}
			set
			{
				if (_imageWidget == value)
				{
					return;
				}
				_imageWidget = value;
				PropertySet(this);
			}
		}

		public sampleImageChanger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
