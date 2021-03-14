using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedWeakspotObject : gameWeakspotObject
	{
		private WeakspotOnDestroyProperties _weakspotOnDestroyProperties;
		private CHandle<entMeshComponent> _mesh;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<entIPlacedComponent> _collider;
		private wCHandle<gameObject> _instigator;
		private WeakspotRecordData _weakspotRecordData;
		private CBool _alive;
		private CBool _hasBeenScanned;

		[Ordinal(40)] 
		[RED("weakspotOnDestroyProperties")] 
		public WeakspotOnDestroyProperties WeakspotOnDestroyProperties
		{
			get
			{
				if (_weakspotOnDestroyProperties == null)
				{
					_weakspotOnDestroyProperties = (WeakspotOnDestroyProperties) CR2WTypeManager.Create("WeakspotOnDestroyProperties", "weakspotOnDestroyProperties", cr2w, this);
				}
				return _weakspotOnDestroyProperties;
			}
			set
			{
				if (_weakspotOnDestroyProperties == value)
				{
					return;
				}
				_weakspotOnDestroyProperties = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get
			{
				if (_interaction == null)
				{
					_interaction = (CHandle<gameinteractionsComponent>) CR2WTypeManager.Create("handle:gameinteractionsComponent", "interaction", cr2w, this);
				}
				return _interaction;
			}
			set
			{
				if (_interaction == value)
				{
					return;
				}
				_interaction = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get
			{
				if (_collider == null)
				{
					_collider = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "collider", cr2w, this);
				}
				return _collider;
			}
			set
			{
				if (_collider == value)
				{
					return;
				}
				_collider = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get
			{
				if (_weakspotRecordData == null)
				{
					_weakspotRecordData = (WeakspotRecordData) CR2WTypeManager.Create("WeakspotRecordData", "weakspotRecordData", cr2w, this);
				}
				return _weakspotRecordData;
			}
			set
			{
				if (_weakspotRecordData == value)
				{
					return;
				}
				_weakspotRecordData = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("alive")] 
		public CBool Alive
		{
			get
			{
				if (_alive == null)
				{
					_alive = (CBool) CR2WTypeManager.Create("Bool", "alive", cr2w, this);
				}
				return _alive;
			}
			set
			{
				if (_alive == value)
				{
					return;
				}
				_alive = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("hasBeenScanned")] 
		public CBool HasBeenScanned
		{
			get
			{
				if (_hasBeenScanned == null)
				{
					_hasBeenScanned = (CBool) CR2WTypeManager.Create("Bool", "hasBeenScanned", cr2w, this);
				}
				return _hasBeenScanned;
			}
			set
			{
				if (_hasBeenScanned == value)
				{
					return;
				}
				_hasBeenScanned = value;
				PropertySet(this);
			}
		}

		public ScriptedWeakspotObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
