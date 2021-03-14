using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalPhoneMessage : gameJournalEntry
	{
		private CEnum<gameMessageSender> _sender;
		private LocalizationString _text;
		private TweakDBID _imageId;
		private CFloat _delay;
		private CHandle<gameJournalPath> _attachment;

		[Ordinal(1)] 
		[RED("sender")] 
		public CEnum<gameMessageSender> Sender
		{
			get
			{
				if (_sender == null)
				{
					_sender = (CEnum<gameMessageSender>) CR2WTypeManager.Create("gameMessageSender", "sender", cr2w, this);
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
		[RED("text")] 
		public LocalizationString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attachment")] 
		public CHandle<gameJournalPath> Attachment
		{
			get
			{
				if (_attachment == null)
				{
					_attachment = (CHandle<gameJournalPath>) CR2WTypeManager.Create("handle:gameJournalPath", "attachment", cr2w, this);
				}
				return _attachment;
			}
			set
			{
				if (_attachment == value)
				{
					return;
				}
				_attachment = value;
				PropertySet(this);
			}
		}

		public gameJournalPhoneMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
