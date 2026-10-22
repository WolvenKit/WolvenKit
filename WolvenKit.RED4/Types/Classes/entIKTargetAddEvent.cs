using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entIKTargetAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(2)] 
		[RED("outIKTargetRef")] 
		public animIKTargetRef OutIKTargetRef
		{
			get => GetPropertyValue<animIKTargetRef>();
			set => SetPropertyValue<animIKTargetRef>(value);
		}

		[Ordinal(3)] 
		[RED("orientationProvider")] 
		public CHandle<entIOrientationProvider> OrientationProvider
		{
			get => GetPropertyValue<CHandle<entIOrientationProvider>>();
			set => SetPropertyValue<CHandle<entIOrientationProvider>>(value);
		}

		[Ordinal(4)] 
		[RED("request")] 
		public animIKTargetRequest Request
		{
			get => GetPropertyValue<animIKTargetRequest>();
			set => SetPropertyValue<animIKTargetRequest>(value);
		}

		public entIKTargetAddEvent()
		{
			BodyPart = "ikRightArm";
			OutIKTargetRef = new animIKTargetRef();
			Request = new animIKTargetRequest();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
