using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDumpBodyDelayEvent : redEvent
	{
		private wCHandle<gameObject> _bodyToDump;
		private CHandle<gameIBlackboard> _psm;

		[Ordinal(0)] 
		[RED("bodyToDump")] 
		public wCHandle<gameObject> BodyToDump
		{
			get => GetProperty(ref _bodyToDump);
			set => SetProperty(ref _bodyToDump, value);
		}

		[Ordinal(1)] 
		[RED("psm")] 
		public CHandle<gameIBlackboard> Psm
		{
			get => GetProperty(ref _psm);
			set => SetProperty(ref _psm, value);
		}

		public VehicleDumpBodyDelayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
