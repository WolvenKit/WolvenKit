using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverridePhantomParamsEventParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(1)] 
		[RED("overrideSpawnEffect")] 
		public CName OverrideSpawnEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("overrideIdleEffect")] 
		public CName OverrideIdleEffect
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnOverridePhantomParamsEventParams()
		{
			Performer = new() { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
