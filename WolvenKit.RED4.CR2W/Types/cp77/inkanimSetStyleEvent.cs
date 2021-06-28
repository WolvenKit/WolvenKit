using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimSetStyleEvent : inkanimEvent
	{
		private raRef<inkStyleResource> _style;

		[Ordinal(1)] 
		[RED("style")] 
		public raRef<inkStyleResource> Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		public inkanimSetStyleEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
