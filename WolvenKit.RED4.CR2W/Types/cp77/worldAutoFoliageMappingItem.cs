using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMappingItem : CVariable
	{
		private CName _material;
		private CUInt32 _layerIndex;
		private raRef<worldFoliageBrush> _foliageBrush;

		[Ordinal(0)] 
		[RED("Material")] 
		public CName Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		[Ordinal(1)] 
		[RED("LayerIndex")] 
		public CUInt32 LayerIndex
		{
			get => GetProperty(ref _layerIndex);
			set => SetProperty(ref _layerIndex, value);
		}

		[Ordinal(2)] 
		[RED("FoliageBrush")] 
		public raRef<worldFoliageBrush> FoliageBrush
		{
			get => GetProperty(ref _foliageBrush);
			set => SetProperty(ref _foliageBrush, value);
		}

		public worldAutoFoliageMappingItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
