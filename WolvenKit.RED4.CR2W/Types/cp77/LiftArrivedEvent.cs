using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LiftArrivedEvent : redEvent
	{
		private CString _floor;

		[Ordinal(0)] 
		[RED("floor")] 
		public CString Floor
		{
			get => GetProperty(ref _floor);
			set => SetProperty(ref _floor, value);
		}

		public LiftArrivedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
