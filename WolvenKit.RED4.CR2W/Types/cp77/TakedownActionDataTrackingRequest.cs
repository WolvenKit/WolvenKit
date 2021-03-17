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
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}

		public TakedownActionDataTrackingRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
