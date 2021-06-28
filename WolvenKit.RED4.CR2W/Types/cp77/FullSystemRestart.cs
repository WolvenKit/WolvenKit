using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FullSystemRestart : ActionBool
	{
		private CInt32 _restartDuration;

		[Ordinal(25)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get => GetProperty(ref _restartDuration);
			set => SetProperty(ref _restartDuration, value);
		}

		public FullSystemRestart(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
