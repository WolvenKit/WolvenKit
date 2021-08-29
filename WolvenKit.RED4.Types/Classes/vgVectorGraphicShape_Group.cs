using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Group : vgBaseVectorGraphicShape
	{
		private CArray<CHandle<vgBaseVectorGraphicShape>> _childShapes;

		[Ordinal(2)] 
		[RED("childShapes")] 
		public CArray<CHandle<vgBaseVectorGraphicShape>> ChildShapes
		{
			get => GetProperty(ref _childShapes);
			set => SetProperty(ref _childShapes, value);
		}
	}
}
