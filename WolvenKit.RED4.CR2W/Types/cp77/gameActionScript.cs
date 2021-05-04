using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionScript : gameIObjectScriptBase
	{
		private CUInt32 _actionFlags;

		[Ordinal(1)] 
		[RED("actionFlags")] 
		public CUInt32 ActionFlags
		{
			get => GetProperty(ref _actionFlags);
			set => SetProperty(ref _actionFlags, value);
		}

		public gameActionScript(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
