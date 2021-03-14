using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tarotCardLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _image;
		private inkWidgetReference _highlight;
		private TarotCardData _data;

		[Ordinal(1)] 
		[RED("image")] 
		public inkImageWidgetReference Image
		{
			get
			{
				if (_image == null)
				{
					_image = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "image", cr2w, this);
				}
				return _image;
			}
			set
			{
				if (_image == value)
				{
					return;
				}
				_image = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("highlight")] 
		public inkWidgetReference Highlight
		{
			get
			{
				if (_highlight == null)
				{
					_highlight = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "highlight", cr2w, this);
				}
				return _highlight;
			}
			set
			{
				if (_highlight == value)
				{
					return;
				}
				_highlight = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("data")] 
		public TarotCardData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (TarotCardData) CR2WTypeManager.Create("TarotCardData", "data", cr2w, this);
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

		public tarotCardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
