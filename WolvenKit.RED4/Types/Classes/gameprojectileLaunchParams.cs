using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileLaunchParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("launchMode")] 
		public CEnum<gameprojectileELaunchMode> LaunchMode
		{
			get => GetPropertyValue<CEnum<gameprojectileELaunchMode>>();
			set => SetPropertyValue<CEnum<gameprojectileELaunchMode>>(value);
		}

		[Ordinal(1)] 
		[RED("logicalPositionProvider")] 
		public CHandle<entIPositionProvider> LogicalPositionProvider
		{
			get => GetPropertyValue<CHandle<entIPositionProvider>>();
			set => SetPropertyValue<CHandle<entIPositionProvider>>(value);
		}

		[Ordinal(2)] 
		[RED("logicalOrientationProvider")] 
		public CHandle<entIOrientationProvider> LogicalOrientationProvider
		{
			get => GetPropertyValue<CHandle<entIOrientationProvider>>();
			set => SetPropertyValue<CHandle<entIOrientationProvider>>(value);
		}

		[Ordinal(3)] 
		[RED("visualPositionProvider")] 
		public CHandle<entIPositionProvider> VisualPositionProvider
		{
			get => GetPropertyValue<CHandle<entIPositionProvider>>();
			set => SetPropertyValue<CHandle<entIPositionProvider>>(value);
		}

		[Ordinal(4)] 
		[RED("visualOrientationProvider")] 
		public CHandle<entIOrientationProvider> VisualOrientationProvider
		{
			get => GetPropertyValue<CHandle<entIOrientationProvider>>();
			set => SetPropertyValue<CHandle<entIOrientationProvider>>(value);
		}

		[Ordinal(5)] 
		[RED("ownerVelocityProvider")] 
		public CHandle<entIVelocityProvider> OwnerVelocityProvider
		{
			get => GetPropertyValue<CHandle<entIVelocityProvider>>();
			set => SetPropertyValue<CHandle<entIVelocityProvider>>(value);
		}

		public gameprojectileLaunchParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
