using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLight : TrafficLight
	{
		private CBool _audioLightIsGreen;

		[Ordinal(90)] 
		[RED("audioLightIsGreen")] 
		public CBool AudioLightIsGreen
		{
			get => GetProperty(ref _audioLightIsGreen);
			set => SetProperty(ref _audioLightIsGreen, value);
		}

		public CrossingLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
