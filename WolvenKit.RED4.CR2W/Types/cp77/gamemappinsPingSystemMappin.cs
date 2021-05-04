using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPingSystemMappin : gamemappinsRuntimeMappin
	{
		private CEnum<gamedataPingType> _pingType;

		[Ordinal(0)] 
		[RED("pingType")] 
		public CEnum<gamedataPingType> PingType
		{
			get => GetProperty(ref _pingType);
			set => SetProperty(ref _pingType, value);
		}

		public gamemappinsPingSystemMappin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
