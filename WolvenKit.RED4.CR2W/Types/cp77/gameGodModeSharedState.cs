using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gameGodModeSharedStateData> _datas;

		[Ordinal(0)] 
		[RED("datas")] 
		public CArray<gameGodModeSharedStateData> Datas
		{
			get => GetProperty(ref _datas);
			set => SetProperty(ref _datas, value);
		}

		public gameGodModeSharedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
