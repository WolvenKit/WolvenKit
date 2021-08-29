using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNewMappinID : RedBaseClass
	{
		private CUInt64 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
