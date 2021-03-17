using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PullSquadSyncRequest : AIAIEvent
	{
		private CEnum<AISquadType> _squadType;

		[Ordinal(2)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetProperty(ref _squadType);
			set => SetProperty(ref _squadType, value);
		}

		public PullSquadSyncRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
