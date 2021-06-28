using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _immediate;

		[Ordinal(0)] 
		[RED("immediate")] 
		public CBool Immediate
		{
			get => GetProperty(ref _immediate);
			set => SetProperty(ref _immediate, value);
		}

		public questSpawnToken_NodeSubType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
