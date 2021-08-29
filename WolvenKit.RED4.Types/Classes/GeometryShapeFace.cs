using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GeometryShapeFace : RedBaseClass
	{
		private CArray<CUInt32> _indices;

		[Ordinal(0)] 
		[RED("indices")] 
		public CArray<CUInt32> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}
	}
}
