using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLookAtAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(2)] 
		[RED("outLookAtRef")] 
		public animLookAtRef OutLookAtRef
		{
			get => GetPropertyValue<animLookAtRef>();
			set => SetPropertyValue<animLookAtRef>(value);
		}

		[Ordinal(3)] 
		[RED("request")] 
		public animLookAtRequest Request
		{
			get => GetPropertyValue<animLookAtRequest>();
			set => SetPropertyValue<animLookAtRequest>(value);
		}

		public entLookAtAddEvent()
		{
			BodyPart = "Eyes";
			OutLookAtRef = new animLookAtRef();
			Request = new animLookAtRequest();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
