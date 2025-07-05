using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpTestComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("whatever")] 
		public CFloat Whatever
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("whateverIE")] 
		public CFloat WhateverIE
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public cpTestComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
