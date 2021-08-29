using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAreaShapeNode : worldNode
	{
		private CColor _color;
		private CHandle<AreaShapeOutline> _outline;

		[Ordinal(4)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetProperty(ref _color);
			set => SetProperty(ref _color, value);
		}

		[Ordinal(5)] 
		[RED("outline")] 
		public CHandle<AreaShapeOutline> Outline
		{
			get => GetProperty(ref _outline);
			set => SetProperty(ref _outline, value);
		}
	}
}
