using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GlitchedTurret : Device
	{
		private CHandle<AnimFeature_SensorDevice> _animFeature;

		[Ordinal(86)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SensorDevice> AnimFeature
		{
			get => GetProperty(ref _animFeature);
			set => SetProperty(ref _animFeature, value);
		}

		public GlitchedTurret(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
