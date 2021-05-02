using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedamageServerKillData : IScriptable
	{
		private CUInt32 _id;
		private gameuiKillInfo _killInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("killInfo")] 
		public gameuiKillInfo KillInfo
		{
			get => GetProperty(ref _killInfo);
			set => SetProperty(ref _killInfo, value);
		}

		public gamedamageServerKillData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
