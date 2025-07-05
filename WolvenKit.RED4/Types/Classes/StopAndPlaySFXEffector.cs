using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopAndPlaySFXEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("sfxToStop")] 
		public CName SfxToStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("sfxToStart")] 
		public CName SfxToStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public StopAndPlaySFXEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
