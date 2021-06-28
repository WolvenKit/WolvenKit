using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemSupport : redEvent
	{
		private CBool _supportGranted;

		[Ordinal(0)] 
		[RED("supportGranted")] 
		public CBool SupportGranted
		{
			get => GetProperty(ref _supportGranted);
			set => SetProperty(ref _supportGranted, value);
		}

		public SecuritySystemSupport(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
