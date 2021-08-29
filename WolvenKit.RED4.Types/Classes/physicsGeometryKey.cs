using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsGeometryKey : RedBaseClass
	{
		private CUInt8 _pe;
		private CArrayFixedSize<CUInt8> _ta;

		[Ordinal(0)] 
		[RED("pe")] 
		public CUInt8 Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("ta", 12)] 
		public CArrayFixedSize<CUInt8> Ta
		{
			get => GetProperty(ref _ta);
			set => SetProperty(ref _ta, value);
		}
	}
}
