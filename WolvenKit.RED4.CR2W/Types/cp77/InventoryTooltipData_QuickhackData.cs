using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_QuickhackData : CVariable
	{
		private CInt32 _memorycost;
		private CInt32 _baseCost;
		private CFloat _uploadTime;
		private CFloat _duration;
		private CFloat _cooldown;
		private CArray<CHandle<DamageEffectUIEntry>> _attackEffects;
		private CFloat _uploadTimeDiff;
		private CFloat _durationDiff;
		private CFloat _cooldownDiff;

		[Ordinal(0)] 
		[RED("memorycost")] 
		public CInt32 Memorycost
		{
			get
			{
				if (_memorycost == null)
				{
					_memorycost = (CInt32) CR2WTypeManager.Create("Int32", "memorycost", cr2w, this);
				}
				return _memorycost;
			}
			set
			{
				if (_memorycost == value)
				{
					return;
				}
				_memorycost = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("baseCost")] 
		public CInt32 BaseCost
		{
			get
			{
				if (_baseCost == null)
				{
					_baseCost = (CInt32) CR2WTypeManager.Create("Int32", "baseCost", cr2w, this);
				}
				return _baseCost;
			}
			set
			{
				if (_baseCost == value)
				{
					return;
				}
				_baseCost = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get
			{
				if (_uploadTime == null)
				{
					_uploadTime = (CFloat) CR2WTypeManager.Create("Float", "uploadTime", cr2w, this);
				}
				return _uploadTime;
			}
			set
			{
				if (_uploadTime == value)
				{
					return;
				}
				_uploadTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get
			{
				if (_cooldown == null)
				{
					_cooldown = (CFloat) CR2WTypeManager.Create("Float", "cooldown", cr2w, this);
				}
				return _cooldown;
			}
			set
			{
				if (_cooldown == value)
				{
					return;
				}
				_cooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attackEffects")] 
		public CArray<CHandle<DamageEffectUIEntry>> AttackEffects
		{
			get
			{
				if (_attackEffects == null)
				{
					_attackEffects = (CArray<CHandle<DamageEffectUIEntry>>) CR2WTypeManager.Create("array:handle:DamageEffectUIEntry", "attackEffects", cr2w, this);
				}
				return _attackEffects;
			}
			set
			{
				if (_attackEffects == value)
				{
					return;
				}
				_attackEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("uploadTimeDiff")] 
		public CFloat UploadTimeDiff
		{
			get
			{
				if (_uploadTimeDiff == null)
				{
					_uploadTimeDiff = (CFloat) CR2WTypeManager.Create("Float", "uploadTimeDiff", cr2w, this);
				}
				return _uploadTimeDiff;
			}
			set
			{
				if (_uploadTimeDiff == value)
				{
					return;
				}
				_uploadTimeDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("durationDiff")] 
		public CFloat DurationDiff
		{
			get
			{
				if (_durationDiff == null)
				{
					_durationDiff = (CFloat) CR2WTypeManager.Create("Float", "durationDiff", cr2w, this);
				}
				return _durationDiff;
			}
			set
			{
				if (_durationDiff == value)
				{
					return;
				}
				_durationDiff = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("cooldownDiff")] 
		public CFloat CooldownDiff
		{
			get
			{
				if (_cooldownDiff == null)
				{
					_cooldownDiff = (CFloat) CR2WTypeManager.Create("Float", "cooldownDiff", cr2w, this);
				}
				return _cooldownDiff;
			}
			set
			{
				if (_cooldownDiff == value)
				{
					return;
				}
				_cooldownDiff = value;
				PropertySet(this);
			}
		}

		public InventoryTooltipData_QuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
