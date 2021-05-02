using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlayEnv_OverrideGlobalLight : questIEnvironmentManagerNodeType
	{
		private worldWorldGlobalLightOverrideWithColorParameters _params;

		[Ordinal(0)] 
		[RED("params")] 
		public worldWorldGlobalLightOverrideWithColorParameters Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public questPlayEnv_OverrideGlobalLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
