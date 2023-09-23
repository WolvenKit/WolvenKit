using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IntercomControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isCalling")] 
		public CBool IsCalling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("sceneStarted")] 
		public CBool SceneStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("endingCall")] 
		public CBool EndingCall
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("forceLookAt")] 
		public entEntityID ForceLookAt
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(111)] 
		[RED("forceFollow")] 
		public CBool ForceFollow
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IntercomControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
