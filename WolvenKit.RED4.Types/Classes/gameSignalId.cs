using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSignalId : RedBaseClass
	{
		private CUInt16 _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CUInt16 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
