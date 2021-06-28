using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyOverlappedSecurityAreas : redEvent
	{
		private CBool _isEntering;
		private gamePersistentID _zoneID;

		[Ordinal(0)] 
		[RED("isEntering")] 
		public CBool IsEntering
		{
			get => GetProperty(ref _isEntering);
			set => SetProperty(ref _isEntering, value);
		}

		[Ordinal(1)] 
		[RED("zoneID")] 
		public gamePersistentID ZoneID
		{
			get => GetProperty(ref _zoneID);
			set => SetProperty(ref _zoneID, value);
		}

		public ModifyOverlappedSecurityAreas(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
