using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_IK : animAnimFeature
	{
		private Vector4 _point;
		private Vector4 _normal;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get => GetProperty(ref _normal);
			set => SetProperty(ref _normal, value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animAnimFeature_IK(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
