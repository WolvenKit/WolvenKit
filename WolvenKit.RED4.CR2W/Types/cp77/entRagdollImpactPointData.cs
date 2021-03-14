using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactPointData : CVariable
	{
		private WorldPosition _worldPosition;
		private Vector4 _worldNormal;
		private CFloat _forceMagnitude;
		private CFloat _impulseMagnitude;
		private CFloat _maxForceMagnitude;
		private CFloat _maxImpulseMagnitude;
		private CFloat _velocityChange;
		private CUInt32 _ragdollProxyActorIndex;
		private CUInt32 _otherProxyActorIndex;

		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (WorldPosition) CR2WTypeManager.Create("WorldPosition", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("worldNormal")] 
		public Vector4 WorldNormal
		{
			get
			{
				if (_worldNormal == null)
				{
					_worldNormal = (Vector4) CR2WTypeManager.Create("Vector4", "worldNormal", cr2w, this);
				}
				return _worldNormal;
			}
			set
			{
				if (_worldNormal == value)
				{
					return;
				}
				_worldNormal = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceMagnitude")] 
		public CFloat ForceMagnitude
		{
			get
			{
				if (_forceMagnitude == null)
				{
					_forceMagnitude = (CFloat) CR2WTypeManager.Create("Float", "forceMagnitude", cr2w, this);
				}
				return _forceMagnitude;
			}
			set
			{
				if (_forceMagnitude == value)
				{
					return;
				}
				_forceMagnitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("impulseMagnitude")] 
		public CFloat ImpulseMagnitude
		{
			get
			{
				if (_impulseMagnitude == null)
				{
					_impulseMagnitude = (CFloat) CR2WTypeManager.Create("Float", "impulseMagnitude", cr2w, this);
				}
				return _impulseMagnitude;
			}
			set
			{
				if (_impulseMagnitude == value)
				{
					return;
				}
				_impulseMagnitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxForceMagnitude")] 
		public CFloat MaxForceMagnitude
		{
			get
			{
				if (_maxForceMagnitude == null)
				{
					_maxForceMagnitude = (CFloat) CR2WTypeManager.Create("Float", "maxForceMagnitude", cr2w, this);
				}
				return _maxForceMagnitude;
			}
			set
			{
				if (_maxForceMagnitude == value)
				{
					return;
				}
				_maxForceMagnitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxImpulseMagnitude")] 
		public CFloat MaxImpulseMagnitude
		{
			get
			{
				if (_maxImpulseMagnitude == null)
				{
					_maxImpulseMagnitude = (CFloat) CR2WTypeManager.Create("Float", "maxImpulseMagnitude", cr2w, this);
				}
				return _maxImpulseMagnitude;
			}
			set
			{
				if (_maxImpulseMagnitude == value)
				{
					return;
				}
				_maxImpulseMagnitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("velocityChange")] 
		public CFloat VelocityChange
		{
			get
			{
				if (_velocityChange == null)
				{
					_velocityChange = (CFloat) CR2WTypeManager.Create("Float", "velocityChange", cr2w, this);
				}
				return _velocityChange;
			}
			set
			{
				if (_velocityChange == value)
				{
					return;
				}
				_velocityChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ragdollProxyActorIndex")] 
		public CUInt32 RagdollProxyActorIndex
		{
			get
			{
				if (_ragdollProxyActorIndex == null)
				{
					_ragdollProxyActorIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "ragdollProxyActorIndex", cr2w, this);
				}
				return _ragdollProxyActorIndex;
			}
			set
			{
				if (_ragdollProxyActorIndex == value)
				{
					return;
				}
				_ragdollProxyActorIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("otherProxyActorIndex")] 
		public CUInt32 OtherProxyActorIndex
		{
			get
			{
				if (_otherProxyActorIndex == null)
				{
					_otherProxyActorIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "otherProxyActorIndex", cr2w, this);
				}
				return _otherProxyActorIndex;
			}
			set
			{
				if (_otherProxyActorIndex == value)
				{
					return;
				}
				_otherProxyActorIndex = value;
				PropertySet(this);
			}
		}

		public entRagdollImpactPointData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
