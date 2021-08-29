using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConvexHull : RedBaseClass
	{
		private CArray<Vector4> _planes;

		[Ordinal(0)] 
		[RED("planes")] 
		public CArray<Vector4> Planes
		{
			get => GetProperty(ref _planes);
			set => SetProperty(ref _planes, value);
		}
	}
}
