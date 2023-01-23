using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpConveyor : gameObject
	{
		[Ordinal(35)] 
		[RED("lines")] 
		public CArray<cpConveyorLine> Lines
		{
			get => GetPropertyValue<CArray<cpConveyorLine>>();
			set => SetPropertyValue<CArray<cpConveyorLine>>(value);
		}

		[Ordinal(36)] 
		[RED("movementCurve")] 
		public CLegacySingleChannelCurve<CFloat> MovementCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(37)] 
		[RED("entityDistance")] 
		public CFloat EntityDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("entitySpawnOffset")] 
		public CFloat EntitySpawnOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("audioParameterLineActive")] 
		public CName AudioParameterLineActive
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(40)] 
		[RED("audioParameterLineCycle")] 
		public CName AudioParameterLineCycle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(41)] 
		[RED("audioParameterLineSpeed")] 
		public CName AudioParameterLineSpeed
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public cpConveyor()
		{
			Lines = new();
			EntityDistance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
