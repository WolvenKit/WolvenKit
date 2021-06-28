using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GeometryShapeFace : CVariable
	{
		private CArray<CUInt32> _indices;

		[Ordinal(0)] 
		[RED("indices")] 
		public CArray<CUInt32> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		public GeometryShapeFace(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
