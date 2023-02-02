using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopVFXEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
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

		public StopVFXEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
