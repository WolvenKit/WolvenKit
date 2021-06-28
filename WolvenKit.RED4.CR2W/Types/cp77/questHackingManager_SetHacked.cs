using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		private CBool _hacked;

		[Ordinal(0)] 
		[RED("hacked")] 
		public CBool Hacked
		{
			get => GetProperty(ref _hacked);
			set => SetProperty(ref _hacked, value);
		}

		public questHackingManager_SetHacked(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
