using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CerberusComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("laserGameEffectUp")] 
		public CHandle<gameEffectInstance> LaserGameEffectUp
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(6)] 
		[RED("laserGameEffectRefUp")] 
		public gameEffectRef LaserGameEffectRefUp
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(7)] 
		[RED("laserGameEffectUp2")] 
		public CHandle<gameEffectInstance> LaserGameEffectUp2
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(8)] 
		[RED("laserGameEffectRefUp2")] 
		public gameEffectRef LaserGameEffectRefUp2
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(9)] 
		[RED("laserGameEffectBeam")] 
		public CHandle<gameEffectInstance> LaserGameEffectBeam
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(10)] 
		[RED("laserGameEffectRefBeam")] 
		public gameEffectRef LaserGameEffectRefBeam
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(11)] 
		[RED("laserGameEffectBottom")] 
		public CHandle<gameEffectInstance> LaserGameEffectBottom
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(12)] 
		[RED("laserGameEffectRefBottom")] 
		public gameEffectRef LaserGameEffectRefBottom
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(13)] 
		[RED("laserGameEffectBottom2")] 
		public CHandle<gameEffectInstance> LaserGameEffectBottom2
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(14)] 
		[RED("laserGameEffectRefBottom2")] 
		public gameEffectRef LaserGameEffectRefBottom2
		{
			get => GetPropertyValue<gameEffectRef>();
			set => SetPropertyValue<gameEffectRef>(value);
		}

		[Ordinal(15)] 
		[RED("gameObject")] 
		public CWeakHandle<gameObject> GameObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public CerberusComponent()
		{
			LaserGameEffectRefUp = new gameEffectRef();
			LaserGameEffectRefUp2 = new gameEffectRef();
			LaserGameEffectRefBeam = new gameEffectRef();
			LaserGameEffectRefBottom = new gameEffectRef();
			LaserGameEffectRefBottom2 = new gameEffectRef();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
