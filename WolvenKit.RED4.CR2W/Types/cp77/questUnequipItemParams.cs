using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUnequipItemParams : CVariable
	{
		private TweakDBID _slotId;
		private CFloat _unequipDurationOverride;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(1)] 
		[RED("unequipDurationOverride")] 
		public CFloat UnequipDurationOverride
		{
			get => GetProperty(ref _unequipDurationOverride);
			set => SetProperty(ref _unequipDurationOverride, value);
		}

		public questUnequipItemParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
