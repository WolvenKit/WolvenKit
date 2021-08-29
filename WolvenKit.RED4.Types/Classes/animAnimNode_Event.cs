using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Event : animAnimNode_FloatValue
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
	}
}
