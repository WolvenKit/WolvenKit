using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioEventPrefetchStruct : CVariable
	{
		private CName _eventName;
		private CEnum<questAudioEventPrefetchMode> _mode;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<questAudioEventPrefetchMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<questAudioEventPrefetchMode>) CR2WTypeManager.Create("questAudioEventPrefetchMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public questAudioEventPrefetchStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
