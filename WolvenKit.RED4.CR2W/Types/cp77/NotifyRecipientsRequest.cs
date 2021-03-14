using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NotifyRecipientsRequest : gameScriptableSystemRequest
	{
		private CArray<RecipientData> _recipients;
		private GameTime _time;

		[Ordinal(0)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get
			{
				if (_recipients == null)
				{
					_recipients = (CArray<RecipientData>) CR2WTypeManager.Create("array:RecipientData", "recipients", cr2w, this);
				}
				return _recipients;
			}
			set
			{
				if (_recipients == value)
				{
					return;
				}
				_recipients = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public GameTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (GameTime) CR2WTypeManager.Create("GameTime", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		public NotifyRecipientsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
