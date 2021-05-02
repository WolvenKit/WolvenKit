using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoverEvent : redEvent
	{
		private CBool _hooverOn;

		[Ordinal(0)] 
		[RED("hooverOn")] 
		public CBool HooverOn
		{
			get => GetProperty(ref _hooverOn);
			set => SetProperty(ref _hooverOn, value);
		}

		public HoverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
