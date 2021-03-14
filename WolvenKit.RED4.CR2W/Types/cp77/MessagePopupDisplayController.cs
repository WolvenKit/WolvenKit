using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessagePopupDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _message;
		private inkImageWidgetReference _image;

		[Ordinal(1)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("message")] 
		public inkTextWidgetReference Message
		{
			get
			{
				if (_message == null)
				{
					_message = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "message", cr2w, this);
				}
				return _message;
			}
			set
			{
				if (_message == value)
				{
					return;
				}
				_message = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public MessagePopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
