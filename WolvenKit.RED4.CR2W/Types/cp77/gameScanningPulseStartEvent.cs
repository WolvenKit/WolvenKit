using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningPulseStartEvent : redEvent
	{
		private CInt32 _targetsAffected;

		[Ordinal(0)] 
		[RED("targetsAffected")] 
		public CInt32 TargetsAffected
		{
			get => GetProperty(ref _targetsAffected);
			set => SetProperty(ref _targetsAffected, value);
		}

		public gameScanningPulseStartEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
