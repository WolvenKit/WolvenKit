using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameComponent : entIComponent
	{
		private CHandle<gamePersistentState> _persistentState;

		[Ordinal(3)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get => GetProperty(ref _persistentState);
			set => SetProperty(ref _persistentState, value);
		}

		public gameComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
