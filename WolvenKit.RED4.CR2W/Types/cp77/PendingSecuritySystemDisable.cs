using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PendingSecuritySystemDisable : redEvent
	{
		private CBool _isPending;

		[Ordinal(0)] 
		[RED("isPending")] 
		public CBool IsPending
		{
			get => GetProperty(ref _isPending);
			set => SetProperty(ref _isPending, value);
		}

		public PendingSecuritySystemDisable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
