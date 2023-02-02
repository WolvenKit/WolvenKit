using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaTypeTransition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transitionTo")] 
		public CEnum<ESecurityAreaType> TransitionTo
		{
			get => GetPropertyValue<CEnum<ESecurityAreaType>>();
			set => SetPropertyValue<CEnum<ESecurityAreaType>>(value);
		}

		[Ordinal(1)] 
		[RED("transitionHour")] 
		public CInt32 TransitionHour
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("transitionMode")] 
		public CEnum<ETransitionMode> TransitionMode
		{
			get => GetPropertyValue<CEnum<ETransitionMode>>();
			set => SetPropertyValue<CEnum<ETransitionMode>>(value);
		}

		[Ordinal(3)] 
		[RED("listenerID")] 
		public CUInt32 ListenerID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("locked")] 
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AreaTypeTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
