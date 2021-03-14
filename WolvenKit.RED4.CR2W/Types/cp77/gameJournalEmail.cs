using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEmail : gameJournalEntry
	{
		private LocalizationString _sender;
		private LocalizationString _addressee;
		private LocalizationString _title;
		private LocalizationString _content;
		private raRef<Bink> _videoResource;
		private TweakDBID _pictureTweak;

		[Ordinal(1)] 
		[RED("sender")] 
		public LocalizationString Sender
		{
			get
			{
				if (_sender == null)
				{
					_sender = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "sender", cr2w, this);
				}
				return _sender;
			}
			set
			{
				if (_sender == value)
				{
					return;
				}
				_sender = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("addressee")] 
		public LocalizationString Addressee
		{
			get
			{
				if (_addressee == null)
				{
					_addressee = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "addressee", cr2w, this);
				}
				return _addressee;
			}
			set
			{
				if (_addressee == value)
				{
					return;
				}
				_addressee = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("title")] 
		public LocalizationString Title
		{
			get
			{
				if (_title == null)
				{
					_title = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "title", cr2w, this);
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

		[Ordinal(4)] 
		[RED("content")] 
		public LocalizationString Content
		{
			get
			{
				if (_content == null)
				{
					_content = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "content", cr2w, this);
				}
				return _content;
			}
			set
			{
				if (_content == value)
				{
					return;
				}
				_content = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("videoResource")] 
		public raRef<Bink> VideoResource
		{
			get
			{
				if (_videoResource == null)
				{
					_videoResource = (raRef<Bink>) CR2WTypeManager.Create("raRef:Bink", "videoResource", cr2w, this);
				}
				return _videoResource;
			}
			set
			{
				if (_videoResource == value)
				{
					return;
				}
				_videoResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("pictureTweak")] 
		public TweakDBID PictureTweak
		{
			get
			{
				if (_pictureTweak == null)
				{
					_pictureTweak = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "pictureTweak", cr2w, this);
				}
				return _pictureTweak;
			}
			set
			{
				if (_pictureTweak == value)
				{
					return;
				}
				_pictureTweak = value;
				PropertySet(this);
			}
		}

		public gameJournalEmail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
