using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterVector : CMaterialParameter
	{
		private Vector4 _vector;

		[Ordinal(2)] 
		[RED("vector")] 
		public Vector4 Vector
		{
			get => GetProperty(ref _vector);
			set => SetProperty(ref _vector, value);
		}

		public CMaterialParameterVector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
