using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDeathTask : AIDeathReactionsTask
	{
		private CHandle<AnimFeature_VehicleNPCDeathData> _vehNPCDeathData;
		private CEnum<gamedataNPCHighLevelState> _previousState;
		private CFloat _timeToRagdoll;
		private CBool _hasRagdolled;
		private CFloat _activationTimeStamp;
		private CBool _readyToUnmount;

		[Ordinal(3)] 
		[RED("vehNPCDeathData")] 
		public CHandle<AnimFeature_VehicleNPCDeathData> VehNPCDeathData
		{
			get
			{
				if (_vehNPCDeathData == null)
				{
					_vehNPCDeathData = (CHandle<AnimFeature_VehicleNPCDeathData>) CR2WTypeManager.Create("handle:AnimFeature_VehicleNPCDeathData", "vehNPCDeathData", cr2w, this);
				}
				return _vehNPCDeathData;
			}
			set
			{
				if (_vehNPCDeathData == value)
				{
					return;
				}
				_vehNPCDeathData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("previousState")] 
		public CEnum<gamedataNPCHighLevelState> PreviousState
		{
			get
			{
				if (_previousState == null)
				{
					_previousState = (CEnum<gamedataNPCHighLevelState>) CR2WTypeManager.Create("gamedataNPCHighLevelState", "previousState", cr2w, this);
				}
				return _previousState;
			}
			set
			{
				if (_previousState == value)
				{
					return;
				}
				_previousState = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeToRagdoll")] 
		public CFloat TimeToRagdoll
		{
			get
			{
				if (_timeToRagdoll == null)
				{
					_timeToRagdoll = (CFloat) CR2WTypeManager.Create("Float", "timeToRagdoll", cr2w, this);
				}
				return _timeToRagdoll;
			}
			set
			{
				if (_timeToRagdoll == value)
				{
					return;
				}
				_timeToRagdoll = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hasRagdolled")] 
		public CBool HasRagdolled
		{
			get
			{
				if (_hasRagdolled == null)
				{
					_hasRagdolled = (CBool) CR2WTypeManager.Create("Bool", "hasRagdolled", cr2w, this);
				}
				return _hasRagdolled;
			}
			set
			{
				if (_hasRagdolled == value)
				{
					return;
				}
				_hasRagdolled = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activationTimeStamp")] 
		public CFloat ActivationTimeStamp
		{
			get
			{
				if (_activationTimeStamp == null)
				{
					_activationTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "activationTimeStamp", cr2w, this);
				}
				return _activationTimeStamp;
			}
			set
			{
				if (_activationTimeStamp == value)
				{
					return;
				}
				_activationTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("readyToUnmount")] 
		public CBool ReadyToUnmount
		{
			get
			{
				if (_readyToUnmount == null)
				{
					_readyToUnmount = (CBool) CR2WTypeManager.Create("Bool", "readyToUnmount", cr2w, this);
				}
				return _readyToUnmount;
			}
			set
			{
				if (_readyToUnmount == value)
				{
					return;
				}
				_readyToUnmount = value;
				PropertySet(this);
			}
		}

		public VehicleDeathTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
