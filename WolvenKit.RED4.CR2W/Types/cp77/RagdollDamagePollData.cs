using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RagdollDamagePollData : CVariable
	{
		private WorldPosition _worldPosition;
		private Vector4 _worldNormal;
		private CFloat _maxForceMagnitude;
		private CFloat _maxImpulseMagnitude;
		private CFloat _maxVelocityChange;
		private CFloat _maxZDiff;

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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("maxVelocityChange")] 
		public CFloat MaxVelocityChange
		{
			get
			{
				if (_maxVelocityChange == null)
				{
					_maxVelocityChange = (CFloat) CR2WTypeManager.Create("Float", "maxVelocityChange", cr2w, this);
				}
				return _maxVelocityChange;
			}
			set
			{
				if (_maxVelocityChange == value)
				{
					return;
				}
				_maxVelocityChange = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("maxZDiff")] 
		public CFloat MaxZDiff
		{
			get
			{
				if (_maxZDiff == null)
				{
					_maxZDiff = (CFloat) CR2WTypeManager.Create("Float", "maxZDiff", cr2w, this);
				}
				return _maxZDiff;
			}
			set
			{
				if (_maxZDiff == value)
				{
					return;
				}
				_maxZDiff = value;
				PropertySet(this);
			}
		}

		public RagdollDamagePollData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
