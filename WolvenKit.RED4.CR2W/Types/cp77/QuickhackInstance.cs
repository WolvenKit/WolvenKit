using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackInstance : ModuleInstance
	{
		private CBool _open;
		private CBool _process;

		[Ordinal(6)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		[Ordinal(7)] 
		[RED("process")] 
		public CBool Process
		{
			get => GetProperty(ref _process);
			set => SetProperty(ref _process, value);
		}

		public QuickhackInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
