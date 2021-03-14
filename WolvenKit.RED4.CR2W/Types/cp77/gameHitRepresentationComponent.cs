using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationComponent : entSlotComponent
	{
		private CArray<gameHitShapeContainer> _representations;
		private CName _physicsMaterial;
		private gameHitShapeBVH _bvhRoot;
		private CBool _useResourceData;
		private raRef<gameHitRepresentationResource> _resource;
		private CArray<gameHitRepresentationOverride> _appearanceOverrides;

		[Ordinal(7)] 
		[RED("representations")] 
		public CArray<gameHitShapeContainer> Representations
		{
			get
			{
				if (_representations == null)
				{
					_representations = (CArray<gameHitShapeContainer>) CR2WTypeManager.Create("array:gameHitShapeContainer", "representations", cr2w, this);
				}
				return _representations;
			}
			set
			{
				if (_representations == value)
				{
					return;
				}
				_representations = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("physicsMaterial")] 
		public CName PhysicsMaterial
		{
			get
			{
				if (_physicsMaterial == null)
				{
					_physicsMaterial = (CName) CR2WTypeManager.Create("CName", "physicsMaterial", cr2w, this);
				}
				return _physicsMaterial;
			}
			set
			{
				if (_physicsMaterial == value)
				{
					return;
				}
				_physicsMaterial = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bvhRoot")] 
		public gameHitShapeBVH BvhRoot
		{
			get
			{
				if (_bvhRoot == null)
				{
					_bvhRoot = (gameHitShapeBVH) CR2WTypeManager.Create("gameHitShapeBVH", "bvhRoot", cr2w, this);
				}
				return _bvhRoot;
			}
			set
			{
				if (_bvhRoot == value)
				{
					return;
				}
				_bvhRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("useResourceData")] 
		public CBool UseResourceData
		{
			get
			{
				if (_useResourceData == null)
				{
					_useResourceData = (CBool) CR2WTypeManager.Create("Bool", "useResourceData", cr2w, this);
				}
				return _useResourceData;
			}
			set
			{
				if (_useResourceData == value)
				{
					return;
				}
				_useResourceData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("resource")] 
		public raRef<gameHitRepresentationResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<gameHitRepresentationResource>) CR2WTypeManager.Create("raRef:gameHitRepresentationResource", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("appearanceOverrides")] 
		public CArray<gameHitRepresentationOverride> AppearanceOverrides
		{
			get
			{
				if (_appearanceOverrides == null)
				{
					_appearanceOverrides = (CArray<gameHitRepresentationOverride>) CR2WTypeManager.Create("array:gameHitRepresentationOverride", "appearanceOverrides", cr2w, this);
				}
				return _appearanceOverrides;
			}
			set
			{
				if (_appearanceOverrides == value)
				{
					return;
				}
				_appearanceOverrides = value;
				PropertySet(this);
			}
		}

		public gameHitRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
