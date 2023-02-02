using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneVOInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inVoTrigger")] 
		public CName InVoTrigger
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("outVoTrigger")] 
		public CName OutVoTrigger
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public scnSceneVOInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
