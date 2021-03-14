using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HeavyFootstepEvent : redEvent
	{
		private wCHandle<gameObject> _instigator;
		private CName _audioEventName;

		[Ordinal(0)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("audioEventName")] 
		public CName AudioEventName
		{
			get
			{
				if (_audioEventName == null)
				{
					_audioEventName = (CName) CR2WTypeManager.Create("CName", "audioEventName", cr2w, this);
				}
				return _audioEventName;
			}
			set
			{
				if (_audioEventName == value)
				{
					return;
				}
				_audioEventName = value;
				PropertySet(this);
			}
		}

		public HeavyFootstepEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
