using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnlocSignature : RedBaseClass
	{
		private CUInt64 _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CUInt64 Val
		{
			get => GetProperty(ref _val);
			set => SetProperty(ref _val, value);
		}
	}
}
