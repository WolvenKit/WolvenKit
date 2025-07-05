using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("flushDuration")] 
		public CFloat FlushDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(108)] 
		[RED("flushSFX")] 
		public CName FlushSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(109)] 
		[RED("flushVFXname")] 
		public CName FlushVFXname
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(110)] 
		[RED("isFlushing")] 
		public CBool IsFlushing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToiletControllerPS()
		{
			FlushDuration = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
