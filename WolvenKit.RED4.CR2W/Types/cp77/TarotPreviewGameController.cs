using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotPreviewGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _background;
		private inkImageWidgetReference _previewImage;
		private inkTextWidgetReference _previewTitle;
		private inkTextWidgetReference _previewDescription;
		private CHandle<TarotCardPreviewData> _data;

		[Ordinal(2)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get
			{
				if (_background == null)
				{
					_background = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "background", cr2w, this);
				}
				return _background;
			}
			set
			{
				if (_background == value)
				{
					return;
				}
				_background = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("previewImage")] 
		public inkImageWidgetReference PreviewImage
		{
			get
			{
				if (_previewImage == null)
				{
					_previewImage = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "previewImage", cr2w, this);
				}
				return _previewImage;
			}
			set
			{
				if (_previewImage == value)
				{
					return;
				}
				_previewImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previewTitle")] 
		public inkTextWidgetReference PreviewTitle
		{
			get
			{
				if (_previewTitle == null)
				{
					_previewTitle = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "previewTitle", cr2w, this);
				}
				return _previewTitle;
			}
			set
			{
				if (_previewTitle == value)
				{
					return;
				}
				_previewTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("previewDescription")] 
		public inkTextWidgetReference PreviewDescription
		{
			get
			{
				if (_previewDescription == null)
				{
					_previewDescription = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "previewDescription", cr2w, this);
				}
				return _previewDescription;
			}
			set
			{
				if (_previewDescription == value)
				{
					return;
				}
				_previewDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("data")] 
		public CHandle<TarotCardPreviewData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<TarotCardPreviewData>) CR2WTypeManager.Create("handle:TarotCardPreviewData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public TarotPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
