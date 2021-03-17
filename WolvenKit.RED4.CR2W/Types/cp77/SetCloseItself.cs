using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCloseItself : redEvent
	{
		private CBool _automaticallyClosesItself;

		[Ordinal(0)] 
		[RED("automaticallyClosesItself")] 
		public CBool AutomaticallyClosesItself
		{
			get => GetProperty(ref _automaticallyClosesItself);
			set => SetProperty(ref _automaticallyClosesItself, value);
		}

		public SetCloseItself(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
