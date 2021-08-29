using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConnectedClassTypes : RedBaseClass
	{
		private CBool _surveillanceCamera;
		private CBool _securityTurret;
		private CBool _puppet;

		[Ordinal(0)] 
		[RED("surveillanceCamera")] 
		public CBool SurveillanceCamera
		{
			get => GetProperty(ref _surveillanceCamera);
			set => SetProperty(ref _surveillanceCamera, value);
		}

		[Ordinal(1)] 
		[RED("securityTurret")] 
		public CBool SecurityTurret
		{
			get => GetProperty(ref _securityTurret);
			set => SetProperty(ref _securityTurret, value);
		}

		[Ordinal(2)] 
		[RED("puppet")] 
		public CBool Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}
	}
}
