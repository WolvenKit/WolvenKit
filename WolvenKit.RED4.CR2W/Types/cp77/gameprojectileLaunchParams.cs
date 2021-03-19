using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchParams : CVariable
	{
		private CEnum<gameprojectileELaunchMode> _launchMode;
		private CHandle<entIPositionProvider> _logicalPositionProvider;
		private CHandle<entIOrientationProvider> _logicalOrientationProvider;
		private CHandle<entIPositionProvider> _visualPositionProvider;
		private CHandle<entIOrientationProvider> _visualOrientationProvider;
		private CHandle<entIVelocityProvider> _ownerVelocityProvider;

		[Ordinal(0)] 
		[RED("launchMode")] 
		public CEnum<gameprojectileELaunchMode> LaunchMode
		{
			get => GetProperty(ref _launchMode);
			set => SetProperty(ref _launchMode, value);
		}

		[Ordinal(1)] 
		[RED("logicalPositionProvider")] 
		public CHandle<entIPositionProvider> LogicalPositionProvider
		{
			get => GetProperty(ref _logicalPositionProvider);
			set => SetProperty(ref _logicalPositionProvider, value);
		}

		[Ordinal(2)] 
		[RED("logicalOrientationProvider")] 
		public CHandle<entIOrientationProvider> LogicalOrientationProvider
		{
			get => GetProperty(ref _logicalOrientationProvider);
			set => SetProperty(ref _logicalOrientationProvider, value);
		}

		[Ordinal(3)] 
		[RED("visualPositionProvider")] 
		public CHandle<entIPositionProvider> VisualPositionProvider
		{
			get => GetProperty(ref _visualPositionProvider);
			set => SetProperty(ref _visualPositionProvider, value);
		}

		[Ordinal(4)] 
		[RED("visualOrientationProvider")] 
		public CHandle<entIOrientationProvider> VisualOrientationProvider
		{
			get => GetProperty(ref _visualOrientationProvider);
			set => SetProperty(ref _visualOrientationProvider, value);
		}

		[Ordinal(5)] 
		[RED("ownerVelocityProvider")] 
		public CHandle<entIVelocityProvider> OwnerVelocityProvider
		{
			get => GetProperty(ref _ownerVelocityProvider);
			set => SetProperty(ref _ownerVelocityProvider, value);
		}

		public gameprojectileLaunchParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
