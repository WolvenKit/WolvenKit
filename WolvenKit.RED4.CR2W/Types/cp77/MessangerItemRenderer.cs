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
			get => GetProperty(ref _image);
			set => SetProperty(ref _image, value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(18)] 
		[RED("fluffText")] 
		public inkTextWidgetReference FluffText
		{
			get => GetProperty(ref _fluffText);
			set => SetProperty(ref _fluffText, value);
		}

		[Ordinal(19)] 
		[RED("stateMessage")] 
		public CName StateMessage
		{
			get => GetProperty(ref _stateMessage);
			set => SetProperty(ref _stateMessage, value);
		}

		[Ordinal(20)] 
		[RED("statePlayerReply")] 
		public CName StatePlayerReply
		{
			get => GetProperty(ref _statePlayerReply);
			set => SetProperty(ref _statePlayerReply, value);
		}

		[Ordinal(21)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetProperty(ref _imageId);
			set => SetProperty(ref _imageId, value);
		}

		public MessangerItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
