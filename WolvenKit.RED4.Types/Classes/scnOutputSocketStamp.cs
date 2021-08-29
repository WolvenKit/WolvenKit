using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnOutputSocketStamp : RedBaseClass
	{
		private CUInt16 _name;
		private CUInt16 _ordinal;

		[Ordinal(0)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get => GetProperty(ref _ordinal);
			set => SetProperty(ref _ordinal, value);
		}
	}
}
