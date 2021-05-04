using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSceneTier2Data : gameSceneTierData
	{
		private CEnum<Tier2WalkType> _walkType;

		[Ordinal(2)] 
		[RED("walkType")] 
		public CEnum<Tier2WalkType> WalkType
		{
			get => GetProperty(ref _walkType);
			set => SetProperty(ref _walkType, value);
		}

		public gameSceneTier2Data(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
