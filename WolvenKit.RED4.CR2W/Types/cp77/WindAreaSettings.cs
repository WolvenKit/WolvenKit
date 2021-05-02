using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _strength;
		private curveData<Vector4> _direction;

		[Ordinal(2)] 
		[RED("strength")] 
		public curveData<CFloat> Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(3)] 
		[RED("direction")] 
		public curveData<Vector4> Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public WindAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
