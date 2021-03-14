using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BeamData : CVariable
	{
		private Vector4 _startDirection;
		private Vector4 _endDirection;
		private CHandle<gameEffectInstance> _effect;
		private wCHandle<gameObject> _target;

		[Ordinal(0)] 
		[RED("startDirection")] 
		public Vector4 StartDirection
		{
			get
			{
				if (_startDirection == null)
				{
					_startDirection = (Vector4) CR2WTypeManager.Create("Vector4", "startDirection", cr2w, this);
				}
				return _startDirection;
			}
			set
			{
				if (_startDirection == value)
				{
					return;
				}
				_startDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("endDirection")] 
		public Vector4 EndDirection
		{
			get
			{
				if (_endDirection == null)
				{
					_endDirection = (Vector4) CR2WTypeManager.Create("Vector4", "endDirection", cr2w, this);
				}
				return _endDirection;
			}
			set
			{
				if (_endDirection == value)
				{
					return;
				}
				_endDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public BeamData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
