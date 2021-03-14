using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendParticleBurst : CVariable
	{
		private CFloat _burstTime;
		private CUInt32 _spawnCount;
		private CFloat _spawnTimeRange;
		private CFloat _repeatTime;

		[Ordinal(0)] 
		[RED("burstTime")] 
		public CFloat BurstTime
		{
			get
			{
				if (_burstTime == null)
				{
					_burstTime = (CFloat) CR2WTypeManager.Create("Float", "burstTime", cr2w, this);
				}
				return _burstTime;
			}
			set
			{
				if (_burstTime == value)
				{
					return;
				}
				_burstTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnCount")] 
		public CUInt32 SpawnCount
		{
			get
			{
				if (_spawnCount == null)
				{
					_spawnCount = (CUInt32) CR2WTypeManager.Create("Uint32", "spawnCount", cr2w, this);
				}
				return _spawnCount;
			}
			set
			{
				if (_spawnCount == value)
				{
					return;
				}
				_spawnCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("spawnTimeRange")] 
		public CFloat SpawnTimeRange
		{
			get
			{
				if (_spawnTimeRange == null)
				{
					_spawnTimeRange = (CFloat) CR2WTypeManager.Create("Float", "spawnTimeRange", cr2w, this);
				}
				return _spawnTimeRange;
			}
			set
			{
				if (_spawnTimeRange == value)
				{
					return;
				}
				_spawnTimeRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("repeatTime")] 
		public CFloat RepeatTime
		{
			get
			{
				if (_repeatTime == null)
				{
					_repeatTime = (CFloat) CR2WTypeManager.Create("Float", "repeatTime", cr2w, this);
				}
				return _repeatTime;
			}
			set
			{
				if (_repeatTime == value)
				{
					return;
				}
				_repeatTime = value;
				PropertySet(this);
			}
		}

		public rendParticleBurst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
