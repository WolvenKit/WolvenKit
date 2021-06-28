using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilmGrainAreaSettings : IAreaSettings
	{
		private curveData<Vector4> _strength;
		private curveData<CFloat> _luminanceBias;
		private Vector3 _grainSize;
		private CBool _applyAfterUpsampling;

		[Ordinal(2)] 
		[RED("strength")] 
		public curveData<Vector4> Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(3)] 
		[RED("luminanceBias")] 
		public curveData<CFloat> LuminanceBias
		{
			get => GetProperty(ref _luminanceBias);
			set => SetProperty(ref _luminanceBias, value);
		}

		[Ordinal(4)] 
		[RED("grainSize")] 
		public Vector3 GrainSize
		{
			get => GetProperty(ref _grainSize);
			set => SetProperty(ref _grainSize, value);
		}

		[Ordinal(5)] 
		[RED("applyAfterUpsampling")] 
		public CBool ApplyAfterUpsampling
		{
			get => GetProperty(ref _applyAfterUpsampling);
			set => SetProperty(ref _applyAfterUpsampling, value);
		}

		public FilmGrainAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
