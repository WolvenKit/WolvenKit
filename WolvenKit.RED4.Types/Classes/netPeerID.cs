using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netPeerID : RedBaseClass
	{
		private CUInt8 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt8 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public netPeerID()
		{
			_value = 255;
		}
	}
}
