using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedReactionSystem : gameScriptableSystem
	{
		private CInt32 _fleeingNPCs;
		private CArray<wCHandle<entEntity>> _runners;
		private CFloat _registeredTimeout;
		private CBool _callInAction;
		private wCHandle<entEntity> _policeCaller;

		[Ordinal(0)] 
		[RED("fleeingNPCs")] 
		public CInt32 FleeingNPCs
		{
			get
			{
				if (_fleeingNPCs == null)
				{
					_fleeingNPCs = (CInt32) CR2WTypeManager.Create("Int32", "fleeingNPCs", cr2w, this);
				}
				return _fleeingNPCs;
			}
			set
			{
				if (_fleeingNPCs == value)
				{
					return;
				}
				_fleeingNPCs = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("runners")] 
		public CArray<wCHandle<entEntity>> Runners
		{
			get
			{
				if (_runners == null)
				{
					_runners = (CArray<wCHandle<entEntity>>) CR2WTypeManager.Create("array:whandle:entEntity", "runners", cr2w, this);
				}
				return _runners;
			}
			set
			{
				if (_runners == value)
				{
					return;
				}
				_runners = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("registeredTimeout")] 
		public CFloat RegisteredTimeout
		{
			get
			{
				if (_registeredTimeout == null)
				{
					_registeredTimeout = (CFloat) CR2WTypeManager.Create("Float", "registeredTimeout", cr2w, this);
				}
				return _registeredTimeout;
			}
			set
			{
				if (_registeredTimeout == value)
				{
					return;
				}
				_registeredTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("callInAction")] 
		public CBool CallInAction
		{
			get
			{
				if (_callInAction == null)
				{
					_callInAction = (CBool) CR2WTypeManager.Create("Bool", "callInAction", cr2w, this);
				}
				return _callInAction;
			}
			set
			{
				if (_callInAction == value)
				{
					return;
				}
				_callInAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("policeCaller")] 
		public wCHandle<entEntity> PoliceCaller
		{
			get
			{
				if (_policeCaller == null)
				{
					_policeCaller = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "policeCaller", cr2w, this);
				}
				return _policeCaller;
			}
			set
			{
				if (_policeCaller == value)
				{
					return;
				}
				_policeCaller = value;
				PropertySet(this);
			}
		}

		public ScriptedReactionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
