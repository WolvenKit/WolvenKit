using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TimetableCallbackData : IScriptable
	{
		private SSimpleGameTime _time;
		private CArray<RecipientData> _recipients;
		private CUInt32 _callbackID;

		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get
			{
				if (_time == null)
				{
					_time = (SSimpleGameTime) CR2WTypeManager.Create("SSimpleGameTime", "time", cr2w, this);
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get
			{
				if (_callbackID == null)
				{
					_callbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackID", cr2w, this);
				}
				return _callbackID;
			}
			set
			{
				if (_callbackID == value)
				{
					return;
				}
				_callbackID = value;
				PropertySet(this);
			}
		}

		public TimetableCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
