using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurveResourceSet : CResource
	{
		private CArray<CurveResourceSetEntry> _curveResources;

		[Ordinal(1)] 
		[RED("curveResources")] 
		public CArray<CurveResourceSetEntry> CurveResources
		{
			get => GetProperty(ref _curveResources);
			set => SetProperty(ref _curveResources, value);
		}
	}
}
