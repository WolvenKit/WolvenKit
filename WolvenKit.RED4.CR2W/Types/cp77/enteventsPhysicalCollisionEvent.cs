using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalCollisionEvent : redEvent
	{
		private wCHandle<IScriptable> _myComponent;
		private wCHandle<IScriptable> _otherEntity;
		private wCHandle<IScriptable> _otherComponent;
		private Vector4 _worldPosition;
		private Vector4 _worldNormal;
		private Vector4 _deltaVelocity;
		private CFloat _impulse;

		[Ordinal(0)] 
		[RED("myComponent")] 
		public wCHandle<IScriptable> MyComponent
		{
			get
			{
				if (_myComponent == null)
				{
					_myComponent = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "myComponent", cr2w, this);
				}
				return _myComponent;
			}
			set
			{
				if (_myComponent == value)
				{
					return;
				}
				_myComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("otherEntity")] 
		public wCHandle<IScriptable> OtherEntity
		{
			get
			{
				if (_otherEntity == null)
				{
					_otherEntity = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "otherEntity", cr2w, this);
				}
				return _otherEntity;
			}
			set
			{
				if (_otherEntity == value)
				{
					return;
				}
				_otherEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("otherComponent")] 
		public wCHandle<IScriptable> OtherComponent
		{
			get
			{
				if (_otherComponent == null)
				{
					_otherComponent = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "otherComponent", cr2w, this);
				}
				return _otherComponent;
			}
			set
			{
				if (_otherComponent == value)
				{
					return;
				}
				_otherComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "worldPosition", cr2w, this);
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("deltaVelocity")] 
		public Vector4 DeltaVelocity
		{
			get
			{
				if (_deltaVelocity == null)
				{
					_deltaVelocity = (Vector4) CR2WTypeManager.Create("Vector4", "deltaVelocity", cr2w, this);
				}
				return _deltaVelocity;
			}
			set
			{
				if (_deltaVelocity == value)
				{
					return;
				}
				_deltaVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("impulse")] 
		public CFloat Impulse
		{
			get
			{
				if (_impulse == null)
				{
					_impulse = (CFloat) CR2WTypeManager.Create("Float", "impulse", cr2w, this);
				}
				return _impulse;
			}
			set
			{
				if (_impulse == value)
				{
					return;
				}
				_impulse = value;
				PropertySet(this);
			}
		}

		public enteventsPhysicalCollisionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
