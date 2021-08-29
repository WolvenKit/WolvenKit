using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAcousticsOutdoornessAreaNode : worldAreaShapeNode
	{
		private CFloat _outdoor;

		[Ordinal(6)] 
		[RED("outdoor")] 
		public CFloat Outdoor
		{
			get => GetProperty(ref _outdoor);
			set => SetProperty(ref _outdoor, value);
		}
	}
}
