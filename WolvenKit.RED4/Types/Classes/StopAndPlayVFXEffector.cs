using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StopAndPlayVFXEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("vfxToStop")] 
		public CName VfxToStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("vfxToStart")] 
		public CName VfxToStart
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

		public StopAndPlayVFXEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
