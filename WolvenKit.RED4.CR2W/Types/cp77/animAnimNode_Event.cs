using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Event : animAnimNode_FloatValue
	{
		private CName _eventName;
		private CFloat _defaultValue;
		private CFloat _eventValue;

		[Ordinal(11)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(12)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(13)] 
		[RED("eventValue")] 
		public CFloat EventValue
		{
			get => GetProperty(ref _eventValue);
			set => SetProperty(ref _eventValue, value);
		}

		public animAnimNode_Event(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
