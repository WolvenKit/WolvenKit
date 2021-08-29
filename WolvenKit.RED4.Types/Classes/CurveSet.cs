using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurveSet : CResource
	{
		private CArray<CurveSetEntry> _curves;

		[Ordinal(1)] 
		[RED("curves")] 
		public CArray<CurveSetEntry> Curves
		{
			get => GetProperty(ref _curves);
			set => SetProperty(ref _curves, value);
		}
	}
}
