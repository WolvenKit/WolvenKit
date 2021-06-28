using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverridePhantomParamsEvent : scnSceneEvent
	{
		private scnOverridePhantomParamsEventParams _params;

		[Ordinal(6)] 
		[RED("params")] 
		public scnOverridePhantomParamsEventParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public scnOverridePhantomParamsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
