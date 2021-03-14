using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMesh_ : resStreamedResource
	{
		private rRef<CMesh> _baseMesh;
		private CArray<MorphTargetMeshEntry> _targets;
		private Box _boundingBox;
		private CName _baseTextureParamName;
		private CHandle<IRenderResourceBlob> _blob;
		private CName _baseMeshAppearance;
		private rRef<ITexture> _baseTexture;

		[Ordinal(1)] 
		[RED("baseMesh")] 
		public rRef<CMesh> BaseMesh
		{
			get
			{
				if (_baseMesh == null)
				{
					_baseMesh = (rRef<CMesh>) CR2WTypeManager.Create("rRef:CMesh", "baseMesh", cr2w, this);
				}
				return _baseMesh;
			}
			set
			{
				if (_baseMesh == value)
				{
					return;
				}
				_baseMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<MorphTargetMeshEntry> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<MorphTargetMeshEntry>) CR2WTypeManager.Create("array:MorphTargetMeshEntry", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get
			{
				if (_boundingBox == null)
				{
					_boundingBox = (Box) CR2WTypeManager.Create("Box", "boundingBox", cr2w, this);
				}
				return _boundingBox;
			}
			set
			{
				if (_boundingBox == value)
				{
					return;
				}
				_boundingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("baseTextureParamName")] 
		public CName BaseTextureParamName
		{
			get
			{
				if (_baseTextureParamName == null)
				{
					_baseTextureParamName = (CName) CR2WTypeManager.Create("CName", "baseTextureParamName", cr2w, this);
				}
				return _baseTextureParamName;
			}
			set
			{
				if (_baseTextureParamName == value)
				{
					return;
				}
				_baseTextureParamName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get
			{
				if (_blob == null)
				{
					_blob = (CHandle<IRenderResourceBlob>) CR2WTypeManager.Create("handle:IRenderResourceBlob", "blob", cr2w, this);
				}
				return _blob;
			}
			set
			{
				if (_blob == value)
				{
					return;
				}
				_blob = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("baseMeshAppearance")] 
		public CName BaseMeshAppearance
		{
			get
			{
				if (_baseMeshAppearance == null)
				{
					_baseMeshAppearance = (CName) CR2WTypeManager.Create("CName", "baseMeshAppearance", cr2w, this);
				}
				return _baseMeshAppearance;
			}
			set
			{
				if (_baseMeshAppearance == value)
				{
					return;
				}
				_baseMeshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("baseTexture")] 
		public rRef<ITexture> BaseTexture
		{
			get
			{
				if (_baseTexture == null)
				{
					_baseTexture = (rRef<ITexture>) CR2WTypeManager.Create("rRef:ITexture", "baseTexture", cr2w, this);
				}
				return _baseTexture;
			}
			set
			{
				if (_baseTexture == value)
				{
					return;
				}
				_baseTexture = value;
				PropertySet(this);
			}
		}

		public MorphTargetMesh_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
