using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TakedownActionDataTrackingRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<ETakedownActionType> _eventType;

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<ETakedownActionType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<ETakedownActionType>) CR2WTypeManager.Create("ETakedownActionType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		public TakedownActionDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
