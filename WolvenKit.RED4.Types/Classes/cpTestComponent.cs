using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpTestComponent : gameComponent
	{
		private CFloat _whatever;
		private CFloat _whateverIE;

		[Ordinal(4)] 
		[RED("whatever")] 
		public CFloat Whatever
		{
			get => GetProperty(ref _whatever);
			set => SetProperty(ref _whatever, value);
		}

		[Ordinal(5)] 
		[RED("whateverIE")] 
		public CFloat WhateverIE
		{
			get => GetProperty(ref _whateverIE);
			set => SetProperty(ref _whateverIE, value);
		}
	}
}
