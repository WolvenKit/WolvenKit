using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitRepresentationResults : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sults")] 
		public CArray<gameHitRepresentationResult> Sults
		{
			get => GetPropertyValue<CArray<gameHitRepresentationResult>>();
			set => SetPropertyValue<CArray<gameHitRepresentationResult>>(value);
		}

		public gameHitRepresentationResults()
		{
			Sults = new();
		}
	}
}
