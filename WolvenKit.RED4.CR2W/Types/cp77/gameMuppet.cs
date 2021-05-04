using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppet : gamePuppetBase
	{
		private CHandle<entSlotComponent> _hitRepresantation;
		private CHandle<entSlotComponent> _slotComponent;
		private CFloat _highDamageThreshold;
		private CFloat _medDamageThreshold;
		private CFloat _lowDamageThreshold;
		private CFloat _effectTimeStamp;

		[Ordinal(40)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetProperty(ref _hitRepresantation);
			set => SetProperty(ref _hitRepresantation, value);
		}

		[Ordinal(41)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		[Ordinal(42)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetProperty(ref _highDamageThreshold);
			set => SetProperty(ref _highDamageThreshold, value);
		}

		[Ordinal(43)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetProperty(ref _medDamageThreshold);
			set => SetProperty(ref _medDamageThreshold, value);
		}

		[Ordinal(44)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetProperty(ref _lowDamageThreshold);
			set => SetProperty(ref _lowDamageThreshold, value);
		}

		[Ordinal(45)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetProperty(ref _effectTimeStamp);
			set => SetProperty(ref _effectTimeStamp, value);
		}

		public gameMuppet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
