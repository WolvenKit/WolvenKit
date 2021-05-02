using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrowdSettingsEvent : redEvent
	{
		private CName _movementType;
		private CBool _resetFear;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CName MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("resetFear")] 
		public CBool ResetFear
		{
			get => GetProperty(ref _resetFear);
			set => SetProperty(ref _resetFear, value);
		}

		public CrowdSettingsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
