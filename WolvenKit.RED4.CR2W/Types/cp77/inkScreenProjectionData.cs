using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScreenProjectionData : CVariable
	{
		private wCHandle<entEntity> _entity;
		private CName _slotComponentName;
		private CName _slotName;
		private CName _slotFallbackName;
		private Vector4 _staticWorldPosition;
		private Vector4 _fixedWorldOffset;
		private wCHandle<IScriptable> _userData;

		[Ordinal(0)] 
		[RED("entity")] 
		public wCHandle<entEntity> Entity
		{
			get
			{
				if (_entity == null)
				{
					_entity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "entity", cr2w, this);
				}
				return _entity;
			}
			set
			{
				if (_entity == value)
				{
					return;
				}
				_entity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotComponentName")] 
		public CName SlotComponentName
		{
			get
			{
				if (_slotComponentName == null)
				{
					_slotComponentName = (CName) CR2WTypeManager.Create("CName", "slotComponentName", cr2w, this);
				}
				return _slotComponentName;
			}
			set
			{
				if (_slotComponentName == value)
				{
					return;
				}
				_slotComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotFallbackName")] 
		public CName SlotFallbackName
		{
			get
			{
				if (_slotFallbackName == null)
				{
					_slotFallbackName = (CName) CR2WTypeManager.Create("CName", "slotFallbackName", cr2w, this);
				}
				return _slotFallbackName;
			}
			set
			{
				if (_slotFallbackName == value)
				{
					return;
				}
				_slotFallbackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("staticWorldPosition")] 
		public Vector4 StaticWorldPosition
		{
			get
			{
				if (_staticWorldPosition == null)
				{
					_staticWorldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "staticWorldPosition", cr2w, this);
				}
				return _staticWorldPosition;
			}
			set
			{
				if (_staticWorldPosition == value)
				{
					return;
				}
				_staticWorldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fixedWorldOffset")] 
		public Vector4 FixedWorldOffset
		{
			get
			{
				if (_fixedWorldOffset == null)
				{
					_fixedWorldOffset = (Vector4) CR2WTypeManager.Create("Vector4", "fixedWorldOffset", cr2w, this);
				}
				return _fixedWorldOffset;
			}
			set
			{
				if (_fixedWorldOffset == value)
				{
					return;
				}
				_fixedWorldOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("userData")] 
		public wCHandle<IScriptable> UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		public inkScreenProjectionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
