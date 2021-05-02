using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Cylinder : CVariable
	{
		private Vector4 _positionAndRadius;
		private Vector4 _normalAndHeight;

		[Ordinal(0)] 
		[RED("positionAndRadius")] 
		public Vector4 PositionAndRadius
		{
			get => GetProperty(ref _positionAndRadius);
			set => SetProperty(ref _positionAndRadius, value);
		}

		[Ordinal(1)] 
		[RED("normalAndHeight")] 
		public Vector4 NormalAndHeight
		{
			get => GetProperty(ref _normalAndHeight);
			set => SetProperty(ref _normalAndHeight, value);
		}

		public Cylinder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
