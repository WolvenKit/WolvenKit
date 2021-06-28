using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltiData_GrenadeData : IScriptable
	{
		private CEnum<GrenadeDamageType> _type;
		private CFloat _range;
		private CFloat _duration;
		private CFloat _delay;
		private CFloat _damagePerTick;
		private CEnum<gamedataStatType> _damageType;
		private CFloat _detonationTimer;
		private CEnum<gamedataGrenadeDeliveryMethodType> _deliveryMethod;
		private CFloat _totalDamage;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GrenadeDamageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(4)] 
		[RED("damagePerTick")] 
		public CFloat DamagePerTick
		{
			get => GetProperty(ref _damagePerTick);
			set => SetProperty(ref _damagePerTick, value);
		}

		[Ordinal(5)] 
		[RED("damageType")] 
		public CEnum<gamedataStatType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(6)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetProperty(ref _detonationTimer);
			set => SetProperty(ref _detonationTimer, value);
		}

		[Ordinal(7)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetProperty(ref _deliveryMethod);
			set => SetProperty(ref _deliveryMethod, value);
		}

		[Ordinal(8)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get => GetProperty(ref _totalDamage);
			set => SetProperty(ref _totalDamage, value);
		}

		public InventoryTooltiData_GrenadeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
