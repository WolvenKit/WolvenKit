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

		[Ordinal(3)] 
		[RED("hitComponent")] 
		public wCHandle<entIComponent> HitComponent
		{
			get
			{
				if (_hitComponent == null)
				{
					_hitComponent = (wCHandle<entIComponent>) CR2WTypeManager.Create("whandle:entIComponent", "hitComponent", cr2w, this);
				}
				return _hitComponent;
			}
			set
			{
				if (_hitComponent == value)
				{
					return;
				}
				_hitComponent = value;
				PropertySet(this);
			}
		}

		public gameprojectileBroadPhaseHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
