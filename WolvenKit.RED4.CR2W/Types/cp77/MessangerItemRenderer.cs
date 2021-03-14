using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessangerItemRenderer : JournalEntryListItemController
	{
		private inkImageWidgetReference _image;
		private inkWidgetReference _container;
		private inkTextWidgetReference _fluffText;
		private CName _stateMessage;
		private CName _statePlayerReply;
		private TweakDBID _imageId;

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get
			{
				if (_container == null)
				{
					_container = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "container", cr2w, this);
				}
				return _container;
			}
			set
			{
				if (_container == value)
				{
					return;
				}
				_container = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get
			{
				if (_fluffText == null)
				{
					_fluffText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffText", cr2w, this);
				}
				return _fluffText;
			}
			set
			{
				if (_fluffText == value)
				{
					return;
				}
				_fluffText = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("stateMessage")] 
		public CName StateMessage
		{
			get
			{
				if (_stateMessage == null)
				{
					_stateMessage = (CName) CR2WTypeManager.Create("CName", "stateMessage", cr2w, this);
				}
				return _stateMessage;
			}
			set
			{
				if (_stateMessage == value)
				{
					return;
				}
				_stateMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("statePlayerReply")] 
		public CName StatePlayerReply
		{
			get
			{
				if (_statePlayerReply == null)
				{
					_statePlayerReply = (CName) CR2WTypeManager.Create("CName", "statePlayerReply", cr2w, this);
				}
				return _statePlayerReply;
			}
			set
			{
				if (_statePlayerReply == value)
				{
					return;
				}
				_statePlayerReply = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get
			{
				if (_imageId == null)
				{
					_imageId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "imageId", cr2w, this);
				}
				return _imageId;
			}
			set
			{
				if (_imageId == value)
				{
					return;
				}
				_imageId = value;
				PropertySet(this);
			}
		}

		public MessangerItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
