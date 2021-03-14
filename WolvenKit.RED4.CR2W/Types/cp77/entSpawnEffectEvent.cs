using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entSpawnEffectEvent : redEvent
	{
		private CHandle<worldEffectBlackboard> _blackboard;
		private CName _effectName;
		private CRUID _idForRandomizedEffect;
		private CName _effectInstanceName;
		private CBool _persistOnDetach;
		private CBool _breakAllLoops;
		private CBool _breakAllOnDestroy;
		private CUInt32 _e3hackDeferCount;

		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<worldEffectBlackboard> Blackboard
		{
			get
			{
				if (_blackboard == null)
				{
					_blackboard = (CHandle<worldEffectBlackboard>) CR2WTypeManager.Create("handle:worldEffectBlackboard", "blackboard", cr2w, this);
				}
				return _blackboard;
			}
			set
			{
				if (_blackboard == value)
				{
					return;
				}
				_blackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("idForRandomizedEffect")] 
		public CRUID IdForRandomizedEffect
		{
			get
			{
				if (_idForRandomizedEffect == null)
				{
					_idForRandomizedEffect = (CRUID) CR2WTypeManager.Create("CRUID", "idForRandomizedEffect", cr2w, this);
				}
				return _idForRandomizedEffect;
			}
			set
			{
				if (_idForRandomizedEffect == value)
				{
					return;
				}
				_idForRandomizedEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effectInstanceName")] 
		public CName EffectInstanceName
		{
			get
			{
				if (_effectInstanceName == null)
				{
					_effectInstanceName = (CName) CR2WTypeManager.Create("CName", "effectInstanceName", cr2w, this);
				}
				return _effectInstanceName;
			}
			set
			{
				if (_effectInstanceName == value)
				{
					return;
				}
				_effectInstanceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get
			{
				if (_persistOnDetach == null)
				{
					_persistOnDetach = (CBool) CR2WTypeManager.Create("Bool", "persistOnDetach", cr2w, this);
				}
				return _persistOnDetach;
			}
			set
			{
				if (_persistOnDetach == value)
				{
					return;
				}
				_persistOnDetach = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("breakAllLoops")] 
		public CBool BreakAllLoops
		{
			get
			{
				if (_breakAllLoops == null)
				{
					_breakAllLoops = (CBool) CR2WTypeManager.Create("Bool", "breakAllLoops", cr2w, this);
				}
				return _breakAllLoops;
			}
			set
			{
				if (_breakAllLoops == value)
				{
					return;
				}
				_breakAllLoops = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("breakAllOnDestroy")] 
		public CBool BreakAllOnDestroy
		{
			get
			{
				if (_breakAllOnDestroy == null)
				{
					_breakAllOnDestroy = (CBool) CR2WTypeManager.Create("Bool", "breakAllOnDestroy", cr2w, this);
				}
				return _breakAllOnDestroy;
			}
			set
			{
				if (_breakAllOnDestroy == value)
				{
					return;
				}
				_breakAllOnDestroy = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("e3hackDeferCount")] 
		public CUInt32 E3hackDeferCount
		{
			get
			{
				if (_e3hackDeferCount == null)
				{
					_e3hackDeferCount = (CUInt32) CR2WTypeManager.Create("Uint32", "e3hackDeferCount", cr2w, this);
				}
				return _e3hackDeferCount;
			}
			set
			{
				if (_e3hackDeferCount == value)
				{
					return;
				}
				_e3hackDeferCount = value;
				PropertySet(this);
			}
		}

		public entSpawnEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
