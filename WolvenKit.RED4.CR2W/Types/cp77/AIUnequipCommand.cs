using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUnequipCommand : AICommand
	{
		private TweakDBID _slotId;
		private CFloat _durationOverride;

		[Ordinal(4)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(5)] 
		[RED("durationOverride")] 
		public CFloat DurationOverride
		{
			get => GetProperty(ref _durationOverride);
			set => SetProperty(ref _durationOverride, value);
		}

		public AIUnequipCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
