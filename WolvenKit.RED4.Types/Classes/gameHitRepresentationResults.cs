using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitRepresentationResults : RedBaseClass
	{
		private CArray<gameHitRepresentationResult> _sults;

		[Ordinal(0)] 
		[RED("sults")] 
		public CArray<gameHitRepresentationResult> Sults
		{
			get => GetProperty(ref _sults);
			set => SetProperty(ref _sults, value);
		}
	}
}
