using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SPreventionAgentData : IScriptable
	{
		private wCHandle<gamePersistentState> _ps;

		[Ordinal(0)] 
		[RED("ps")] 
		public wCHandle<gamePersistentState> Ps
		{
			get => GetProperty(ref _ps);
			set => SetProperty(ref _ps, value);
		}

		public SPreventionAgentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
