using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entHitRepresentationDataParameter : entEntityParameter
	{
		private CArray<gameHitRepresentationOverride> _hitRepresentationOverrides;

		[Ordinal(0)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get => GetProperty(ref _hitRepresentationOverrides);
			set => SetProperty(ref _hitRepresentationOverrides, value);
		}
	}
}
