using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileHitInstance : CVariable
	{
		private physicsTraceResult _traceResult;
		private Vector4 _position;
		private Vector4 _projectilePosition;
		private Vector4 _projectileSourcePosition;
		private Vector4 _forward;
		private Vector4 _velocity;
		private wCHandle<entEntity> _hitObject;
		private wCHandle<gameWeakspotObject> _hitWeakspot;
		private gameQueryResult _hitRepresentationResult;
		private CInt32 _numRicochetBounces;

		[Ordinal(0)] 
		[RED("traceResult")] 
		public physicsTraceResult TraceResult
		{
			get
			{
				if (_traceResult == null)
				{
					_traceResult = (physicsTraceResult) CR2WTypeManager.Create("physicsTraceResult", "traceResult", cr2w, this);
				}
				return _traceResult;
			}
			set
			{
				if (_traceResult == value)
				{
					return;
				}
				_traceResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get
			{
				if (_projectilePosition == null)
				{
					_projectilePosition = (Vector4) CR2WTypeManager.Create("Vector4", "projectilePosition", cr2w, this);
				}
				return _projectilePosition;
			}
			set
			{
				if (_projectilePosition == value)
				{
					return;
				}
				_projectilePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("projectileSourcePosition")] 
		public Vector4 ProjectileSourcePosition
		{
			get
			{
				if (_projectileSourcePosition == null)
				{
					_projectileSourcePosition = (Vector4) CR2WTypeManager.Create("Vector4", "projectileSourcePosition", cr2w, this);
				}
				return _projectileSourcePosition;
			}
			set
			{
				if (_projectileSourcePosition == value)
				{
					return;
				}
				_projectileSourcePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get
			{
				if (_forward == null)
				{
					_forward = (Vector4) CR2WTypeManager.Create("Vector4", "forward", cr2w, this);
				}
				return _forward;
			}
			set
			{
				if (_forward == value)
				{
					return;
				}
				_forward = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (Vector4) CR2WTypeManager.Create("Vector4", "velocity", cr2w, this);
				}
				return _velocity;
			}
			set
			{
				if (_velocity == value)
				{
					return;
				}
				_velocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hitObject")] 
		public wCHandle<entEntity> HitObject
		{
			get
			{
				if (_hitObject == null)
				{
					_hitObject = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "hitObject", cr2w, this);
				}
				return _hitObject;
			}
			set
			{
				if (_hitObject == value)
				{
					return;
				}
				_hitObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hitWeakspot")] 
		public wCHandle<gameWeakspotObject> HitWeakspot
		{
			get
			{
				if (_hitWeakspot == null)
				{
					_hitWeakspot = (wCHandle<gameWeakspotObject>) CR2WTypeManager.Create("whandle:gameWeakspotObject", "hitWeakspot", cr2w, this);
				}
				return _hitWeakspot;
			}
			set
			{
				if (_hitWeakspot == value)
				{
					return;
				}
				_hitWeakspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hitRepresentationResult")] 
		public gameQueryResult HitRepresentationResult
		{
			get
			{
				if (_hitRepresentationResult == null)
				{
					_hitRepresentationResult = (gameQueryResult) CR2WTypeManager.Create("gameQueryResult", "hitRepresentationResult", cr2w, this);
				}
				return _hitRepresentationResult;
			}
			set
			{
				if (_hitRepresentationResult == value)
				{
					return;
				}
				_hitRepresentationResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get
			{
				if (_numRicochetBounces == null)
				{
					_numRicochetBounces = (CInt32) CR2WTypeManager.Create("Int32", "numRicochetBounces", cr2w, this);
				}
				return _numRicochetBounces;
			}
			set
			{
				if (_numRicochetBounces == value)
				{
					return;
				}
				_numRicochetBounces = value;
				PropertySet(this);
			}
		}

		public gameprojectileHitInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
