using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WireRepairable : gameObject
	{
		private CBool _isBroken;
		private CArray<NodeRef> _dependableEntities;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<entIVisualComponent> _brokenmesh;
		private CHandle<entIVisualComponent> _fixedmesh;

		[Ordinal(40)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get
			{
				if (_isBroken == null)
				{
					_isBroken = (CBool) CR2WTypeManager.Create("Bool", "isBroken", cr2w, this);
				}
				return _isBroken;
			}
			set
			{
				if (_isBroken == value)
				{
					return;
				}
				_isBroken = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("dependableEntities")] 
		public CArray<NodeRef> DependableEntities
		{
			get
			{
				if (_dependableEntities == null)
				{
					_dependableEntities = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "dependableEntities", cr2w, this);
				}
				return _dependableEntities;
			}
			set
			{
				if (_dependableEntities == value)
				{
					return;
				}
				_dependableEntities = value;
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
		[RED("brokenmesh")] 
		public CHandle<entIVisualComponent> Brokenmesh
		{
			get
			{
				if (_brokenmesh == null)
				{
					_brokenmesh = (CHandle<entIVisualComponent>) CR2WTypeManager.Create("handle:entIVisualComponent", "brokenmesh", cr2w, this);
				}
				return _brokenmesh;
			}
			set
			{
				if (_brokenmesh == value)
				{
					return;
				}
				_brokenmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("fixedmesh")] 
		public CHandle<entIVisualComponent> Fixedmesh
		{
			get
			{
				if (_fixedmesh == null)
				{
					_fixedmesh = (CHandle<entIVisualComponent>) CR2WTypeManager.Create("handle:entIVisualComponent", "fixedmesh", cr2w, this);
				}
				return _fixedmesh;
			}
			set
			{
				if (_fixedmesh == value)
				{
					return;
				}
				_fixedmesh = value;
				PropertySet(this);
			}
		}

		public WireRepairable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
