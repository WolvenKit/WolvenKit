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
			get => GetProperty(ref _traceResult);
			set => SetProperty(ref _traceResult, value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(2)] 
		[RED("projectilePosition")] 
		public Vector4 ProjectilePosition
		{
			get => GetProperty(ref _projectilePosition);
			set => SetProperty(ref _projectilePosition, value);
		}

		[Ordinal(3)] 
		[RED("projectileSourcePosition")] 
		public Vector4 ProjectileSourcePosition
		{
			get => GetProperty(ref _projectileSourcePosition);
			set => SetProperty(ref _projectileSourcePosition, value);
		}

		[Ordinal(4)] 
		[RED("forward")] 
		public Vector4 Forward
		{
			get => GetProperty(ref _forward);
			set => SetProperty(ref _forward, value);
		}

		[Ordinal(5)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get => GetProperty(ref _velocity);
			set => SetProperty(ref _velocity, value);
		}

		[Ordinal(6)] 
		[RED("hitObject")] 
		public wCHandle<entEntity> HitObject
		{
			get => GetProperty(ref _hitObject);
			set => SetProperty(ref _hitObject, value);
		}

		[Ordinal(7)] 
		[RED("hitWeakspot")] 
		public wCHandle<gameWeakspotObject> HitWeakspot
		{
			get => GetProperty(ref _hitWeakspot);
			set => SetProperty(ref _hitWeakspot, value);
		}

		[Ordinal(8)] 
		[RED("hitRepresentationResult")] 
		public gameQueryResult HitRepresentationResult
		{
			get => GetProperty(ref _hitRepresentationResult);
			set => SetProperty(ref _hitRepresentationResult, value);
		}

		[Ordinal(9)] 
		[RED("numRicochetBounces")] 
		public CInt32 NumRicochetBounces
		{
			get => GetProperty(ref _numRicochetBounces);
			set => SetProperty(ref _numRicochetBounces, value);
		}

		public gameprojectileHitInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
