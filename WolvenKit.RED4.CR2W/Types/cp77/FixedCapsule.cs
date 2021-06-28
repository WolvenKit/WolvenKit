using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixedCapsule : CVariable
	{
		private Vector4 _pointRadius;
		private CFloat _height;

		[Ordinal(0)] 
		[RED("PointRadius")] 
		public Vector4 PointRadius
		{
			get => GetProperty(ref _pointRadius);
			set => SetProperty(ref _pointRadius, value);
		}

		[Ordinal(1)] 
		[RED("Height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		public FixedCapsule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
