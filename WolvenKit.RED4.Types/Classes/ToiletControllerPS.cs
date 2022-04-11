using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToiletControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("flushDuration")] 
		public CFloat FlushDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(105)] 
		[RED("flushSFX")] 
		public CName FlushSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(106)] 
		[RED("flushVFXname")] 
		public CName FlushVFXname
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(107)] 
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
