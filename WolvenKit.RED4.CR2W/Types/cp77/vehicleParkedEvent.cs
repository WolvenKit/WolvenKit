using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleParkedEvent : redEvent
	{
		private CBool _park;

		[Ordinal(0)] 
		[RED("park")] 
		public CBool Park
		{
			get => GetProperty(ref _park);
			set => SetProperty(ref _park, value);
		}

		public vehicleParkedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
