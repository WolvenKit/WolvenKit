using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectComponentPS : gameComponentPS
	{
		private CArray<gameStatusEffect> _statusEffectArray;
		private CHandle<gameDelayedFunctionsScheduler> _delayedFunctions;
		private CHandle<gameDelayedFunctionsScheduler> _delayedFunctionsNoTd;
		private CBool _isPlayerControlled;
		private CBool _tickComponent;

		[Ordinal(0)] 
		[RED("statusEffectArray")] 
		public CArray<gameStatusEffect> StatusEffectArray
		{
			get
			{
				if (_statusEffectArray == null)
				{
					_statusEffectArray = (CArray<gameStatusEffect>) CR2WTypeManager.Create("array:gameStatusEffect", "statusEffectArray", cr2w, this);
				}
				return _statusEffectArray;
			}
			set
			{
				if (_statusEffectArray == value)
				{
					return;
				}
				_statusEffectArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("delayedFunctions")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctions
		{
			get
			{
				if (_delayedFunctions == null)
				{
					_delayedFunctions = (CHandle<gameDelayedFunctionsScheduler>) CR2WTypeManager.Create("handle:gameDelayedFunctionsScheduler", "delayedFunctions", cr2w, this);
				}
				return _delayedFunctions;
			}
			set
			{
				if (_delayedFunctions == value)
				{
					return;
				}
				_delayedFunctions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delayedFunctionsNoTd")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctionsNoTd
		{
			get
			{
				if (_delayedFunctionsNoTd == null)
				{
					_delayedFunctionsNoTd = (CHandle<gameDelayedFunctionsScheduler>) CR2WTypeManager.Create("handle:gameDelayedFunctionsScheduler", "delayedFunctionsNoTd", cr2w, this);
				}
				return _delayedFunctionsNoTd;
			}
			set
			{
				if (_delayedFunctionsNoTd == value)
				{
					return;
				}
				_delayedFunctionsNoTd = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get
			{
				if (_isPlayerControlled == null)
				{
					_isPlayerControlled = (CBool) CR2WTypeManager.Create("Bool", "isPlayerControlled", cr2w, this);
				}
				return _isPlayerControlled;
			}
			set
			{
				if (_isPlayerControlled == value)
				{
					return;
				}
				_isPlayerControlled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("tickComponent")] 
		public CBool TickComponent
		{
			get
			{
				if (_tickComponent == null)
				{
					_tickComponent = (CBool) CR2WTypeManager.Create("Bool", "tickComponent", cr2w, this);
				}
				return _tickComponent;
			}
			set
			{
				if (_tickComponent == value)
				{
					return;
				}
				_tickComponent = value;
				PropertySet(this);
			}
		}

		public gameStatusEffectComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
