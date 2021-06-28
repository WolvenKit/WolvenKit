using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRoadMaterialInfo : CVariable
	{
		private CFloat _startOffset;
		private CEnum<worldRoadMaterial> _material;

		[Ordinal(0)] 
		[RED("startOffset")] 
		public CFloat StartOffset
		{
			get => GetProperty(ref _startOffset);
			set => SetProperty(ref _startOffset, value);
		}

		[Ordinal(1)] 
		[RED("material")] 
		public CEnum<worldRoadMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public worldRoadMaterialInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
