using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_WeaponData : animAnimFeature
	{
		private CFloat _cycleTime;
		private CFloat _chargePercentage;
		private CFloat _timeInMaxCharge;
		private CInt32 _ammoRemaining;
		private CInt32 _triggerMode;
		private CBool _isMagazineFull;
		private CBool _isTriggerDown;

		[Ordinal(0)] 
		[RED("cycleTime")] 
		public CFloat CycleTime
		{
			get => GetProperty(ref _cycleTime);
			set => SetProperty(ref _cycleTime, value);
		}

		[Ordinal(1)] 
		[RED("chargePercentage")] 
		public CFloat ChargePercentage
		{
			get => GetProperty(ref _chargePercentage);
			set => SetProperty(ref _chargePercentage, value);
		}

		[Ordinal(2)] 
		[RED("timeInMaxCharge")] 
		public CFloat TimeInMaxCharge
		{
			get => GetProperty(ref _timeInMaxCharge);
			set => SetProperty(ref _timeInMaxCharge, value);
		}

		[Ordinal(3)] 
		[RED("ammoRemaining")] 
		public CInt32 AmmoRemaining
		{
			get => GetProperty(ref _ammoRemaining);
			set => SetProperty(ref _ammoRemaining, value);
		}

		[Ordinal(4)] 
		[RED("triggerMode")] 
		public CInt32 TriggerMode
		{
			get => GetProperty(ref _triggerMode);
			set => SetProperty(ref _triggerMode, value);
		}

		[Ordinal(5)] 
		[RED("isMagazineFull")] 
		public CBool IsMagazineFull
		{
			get => GetProperty(ref _isMagazineFull);
			set => SetProperty(ref _isMagazineFull, value);
		}

		[Ordinal(6)] 
		[RED("isTriggerDown")] 
		public CBool IsTriggerDown
		{
			get => GetProperty(ref _isTriggerDown);
			set => SetProperty(ref _isTriggerDown, value);
		}

		public gameweaponAnimFeature_WeaponData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
