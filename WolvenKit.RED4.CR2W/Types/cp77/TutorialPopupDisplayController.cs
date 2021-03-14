using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TutorialPopupDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _message;
		private inkImageWidgetReference _image;
		private inkVideoWidgetReference _video_1360x768;
		private inkVideoWidgetReference _video_1024x576;
		private inkVideoWidgetReference _video_1280x720;
		private inkVideoWidgetReference _video_720x405;
		private inkWidgetReference _inputHint;

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

		[Ordinal(4)] 
		[RED("video_1360x768")] 
		public inkVideoWidgetReference Video_1360x768
		{
			get
			{
				if (_video_1360x768 == null)
				{
					_video_1360x768 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "video_1360x768", cr2w, this);
				}
				return _video_1360x768;
			}
			set
			{
				if (_video_1360x768 == value)
				{
					return;
				}
				_video_1360x768 = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("video_1024x576")] 
		public inkVideoWidgetReference Video_1024x576
		{
			get
			{
				if (_video_1024x576 == null)
				{
					_video_1024x576 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "video_1024x576", cr2w, this);
				}
				return _video_1024x576;
			}
			set
			{
				if (_video_1024x576 == value)
				{
					return;
				}
				_video_1024x576 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("video_1280x720")] 
		public inkVideoWidgetReference Video_1280x720
		{
			get
			{
				if (_video_1280x720 == null)
				{
					_video_1280x720 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "video_1280x720", cr2w, this);
				}
				return _video_1280x720;
			}
			set
			{
				if (_video_1280x720 == value)
				{
					return;
				}
				_video_1280x720 = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("video_720x405")] 
		public inkVideoWidgetReference Video_720x405
		{
			get
			{
				if (_video_720x405 == null)
				{
					_video_720x405 = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "video_720x405", cr2w, this);
				}
				return _video_720x405;
			}
			set
			{
				if (_video_720x405 == value)
				{
					return;
				}
				_video_720x405 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inputHint")] 
		public inkWidgetReference InputHint
		{
			get
			{
				if (_inputHint == null)
				{
					_inputHint = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "inputHint", cr2w, this);
				}
				return _inputHint;
			}
			set
			{
				if (_inputHint == value)
				{
					return;
				}
				_inputHint = value;
				PropertySet(this);
			}
		}

		public TutorialPopupDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
