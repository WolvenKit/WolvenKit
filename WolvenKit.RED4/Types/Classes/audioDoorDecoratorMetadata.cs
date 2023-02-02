using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDoorDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("startOpen")] 
		public CName StartOpen
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("startClose")] 
		public CName StartClose
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("endOpen")] 
		public CName EndOpen
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("endClose")] 
		public CName EndClose
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("openLoop")] 
		public CName OpenLoop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("closeLoop")] 
		public CName CloseLoop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("openTime")] 
		public CFloat OpenTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("closeTime")] 
		public CFloat CloseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioDoorDecoratorMetadata()
		{
			OpenTime = 1.000000F;
			CloseTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
