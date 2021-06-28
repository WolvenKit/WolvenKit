using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileBroadPhaseHitEvent : redEvent
	{
		private physicsTraceResult _traceResult;
		private Vector4 _position;
		private wCHandle<entEntity> _hitObject;
		private wCHandle<entIComponent> _hitComponent;

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
		[RED("hitObject")] 
		public wCHandle<entEntity> HitObject
		{
			get => GetProperty(ref _hitObject);
			set => SetProperty(ref _hitObject, value);
		}

		[Ordinal(3)] 
		[RED("hitComponent")] 
		public wCHandle<entIComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}

		public gameprojectileBroadPhaseHitEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
