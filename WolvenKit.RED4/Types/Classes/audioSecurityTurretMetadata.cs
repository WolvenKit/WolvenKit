using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioSecurityTurretMetadata : audioCustomEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("singleFire")] 
		public CName SingleFire
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CName Activated
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("deactivaed")] 
		public CName Deactivaed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("destroyed")] 
		public CName Destroyed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("idleStart")] 
		public CName IdleStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("idleStop")] 
		public CName IdleStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("triggerEffectSingle")] 
		public CName TriggerEffectSingle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("triggerEffectAuto")] 
		public CName TriggerEffectAuto
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("obstructionEnabled")] 
		public CBool ObstructionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public audioSecurityTurretMetadata()
		{
			ObstructionEnabled = true;
			OcclusionEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
