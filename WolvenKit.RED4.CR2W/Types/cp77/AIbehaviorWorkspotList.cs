using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorWorkspotList : IScriptable
	{
		private CArray<NodeRef> _spots;

		[Ordinal(0)] 
		[RED("spots")] 
		public CArray<NodeRef> Spots
		{
			get => GetProperty(ref _spots);
			set => SetProperty(ref _spots, value);
		}

		public AIbehaviorWorkspotList(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
