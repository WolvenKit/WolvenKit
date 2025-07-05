using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopSFXEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public StopSFXEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
