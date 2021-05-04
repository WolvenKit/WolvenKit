using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerFacingBeam : IParticleDrawer
	{
		private CFloat _texturesPerUnit;
		private CBool _dynamicTexCoords;
		private CFloat _transparencyOffset;
		private CFloat _transparencyLength;
		private CUInt32 _numSegments;
		private Vector4 _sourceTangent;
		private Vector4 _targetTangent;
		private Vector3 _debugTargetTranslation;

		[Ordinal(1)] 
		[RED("texturesPerUnit")] 
		public CFloat TexturesPerUnit
		{
			get => GetProperty(ref _texturesPerUnit);
			set => SetProperty(ref _texturesPerUnit, value);
		}

		[Ordinal(2)] 
		[RED("dynamicTexCoords")] 
		public CBool DynamicTexCoords
		{
			get => GetProperty(ref _dynamicTexCoords);
			set => SetProperty(ref _dynamicTexCoords, value);
		}

		[Ordinal(3)] 
		[RED("transparencyOffset")] 
		public CFloat TransparencyOffset
		{
			get => GetProperty(ref _transparencyOffset);
			set => SetProperty(ref _transparencyOffset, value);
		}

		[Ordinal(4)] 
		[RED("transparencyLength")] 
		public CFloat TransparencyLength
		{
			get => GetProperty(ref _transparencyLength);
			set => SetProperty(ref _transparencyLength, value);
		}

		[Ordinal(5)] 
		[RED("numSegments")] 
		public CUInt32 NumSegments
		{
			get => GetProperty(ref _numSegments);
			set => SetProperty(ref _numSegments, value);
		}

		[Ordinal(6)] 
		[RED("sourceTangent")] 
		public Vector4 SourceTangent
		{
			get => GetProperty(ref _sourceTangent);
			set => SetProperty(ref _sourceTangent, value);
		}

		[Ordinal(7)] 
		[RED("targetTangent")] 
		public Vector4 TargetTangent
		{
			get => GetProperty(ref _targetTangent);
			set => SetProperty(ref _targetTangent, value);
		}

		[Ordinal(8)] 
		[RED("debugTargetTranslation")] 
		public Vector3 DebugTargetTranslation
		{
			get => GetProperty(ref _debugTargetTranslation);
			set => SetProperty(ref _debugTargetTranslation, value);
		}

		public CParticleDrawerFacingBeam(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
