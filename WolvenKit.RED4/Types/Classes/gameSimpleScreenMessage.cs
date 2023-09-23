using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSimpleScreenMessage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameSimpleMessageType> Type
		{
			get => GetPropertyValue<CEnum<gameSimpleMessageType>>();
			set => SetPropertyValue<CEnum<gameSimpleMessageType>>(value);
		}

		public gameSimpleScreenMessage()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
