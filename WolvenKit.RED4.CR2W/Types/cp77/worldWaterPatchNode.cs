using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWaterPatchNode : worldMeshNode
	{
		private worldWaterPatchNodeType _type;
		private CFloat _depth;

		[Ordinal(15)] 
		[RED("type")] 
		public worldWaterPatchNodeType Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(16)] 
		[RED("depth")] 
		public CFloat Depth
		{
			get => GetProperty(ref _depth);
			set => SetProperty(ref _depth, value);
		}

		public worldWaterPatchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
