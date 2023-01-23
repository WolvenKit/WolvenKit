using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ConnectedClassTypes : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("surveillanceCamera")] 
		public CBool SurveillanceCamera
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("securityTurret")] 
		public CBool SecurityTurret
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("puppet")] 
		public CBool Puppet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ConnectedClassTypes()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
