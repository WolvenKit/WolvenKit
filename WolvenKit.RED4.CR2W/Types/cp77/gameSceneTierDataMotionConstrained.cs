using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTierDataMotionConstrained : gameSceneTierData
	{
		private gameMotionConstrainedTierDataParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public gameMotionConstrainedTierDataParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		public gameSceneTierDataMotionConstrained(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
