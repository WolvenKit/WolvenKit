using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseShapes : RedBaseClass
	{
		private CArray<CHandle<senseIShape>> _shapes;

		[Ordinal(0)] 
		[RED("shapes")] 
		public CArray<CHandle<senseIShape>> Shapes
		{
			get => GetProperty(ref _shapes);
			set => SetProperty(ref _shapes, value);
		}
	}
}
