using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioTierEvent : redEvent
	{
		private CUInt32 _radioTier;
		private CBool _overrideTier;

		[Ordinal(0)] 
		[RED("radioTier")] 
		public CUInt32 RadioTier
		{
			get => GetProperty(ref _radioTier);
			set => SetProperty(ref _radioTier, value);
		}

		[Ordinal(1)] 
		[RED("overrideTier")] 
		public CBool OverrideTier
		{
			get => GetProperty(ref _overrideTier);
			set => SetProperty(ref _overrideTier, value);
		}

		public VehicleRadioTierEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
