using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearancePartComponentOverrides : CVariable
	{
		private CName _componentName;
		private CName _meshAppearance;
		private CUInt64 _chunkMask;
		private CBool _useCustomTransform;
		private Transform _initialTransform;
		private Vector3 _visualScale;
		private CBool _acceptDismemberment;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get
			{
				if (_meshAppearance == null)
				{
					_meshAppearance = (CName) CR2WTypeManager.Create("CName", "meshAppearance", cr2w, this);
				}
				return _meshAppearance;
			}
			set
			{
				if (_meshAppearance == value)
				{
					return;
				}
				_meshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get
			{
				if (_chunkMask == null)
				{
					_chunkMask = (CUInt64) CR2WTypeManager.Create("Uint64", "chunkMask", cr2w, this);
				}
				return _chunkMask;
			}
			set
			{
				if (_chunkMask == value)
				{
					return;
				}
				_chunkMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useCustomTransform")] 
		public CBool UseCustomTransform
		{
			get
			{
				if (_useCustomTransform == null)
				{
					_useCustomTransform = (CBool) CR2WTypeManager.Create("Bool", "useCustomTransform", cr2w, this);
				}
				return _useCustomTransform;
			}
			set
			{
				if (_useCustomTransform == value)
				{
					return;
				}
				_useCustomTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get
			{
				if (_initialTransform == null)
				{
					_initialTransform = (Transform) CR2WTypeManager.Create("Transform", "initialTransform", cr2w, this);
				}
				return _initialTransform;
			}
			set
			{
				if (_initialTransform == value)
				{
					return;
				}
				_initialTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("visualScale")] 
		public Vector3 VisualScale
		{
			get
			{
				if (_visualScale == null)
				{
					_visualScale = (Vector3) CR2WTypeManager.Create("Vector3", "visualScale", cr2w, this);
				}
				return _visualScale;
			}
			set
			{
				if (_visualScale == value)
				{
					return;
				}
				_visualScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get
			{
				if (_acceptDismemberment == null)
				{
					_acceptDismemberment = (CBool) CR2WTypeManager.Create("Bool", "acceptDismemberment", cr2w, this);
				}
				return _acceptDismemberment;
			}
			set
			{
				if (_acceptDismemberment == value)
				{
					return;
				}
				_acceptDismemberment = value;
				PropertySet(this);
			}
		}

		public appearancePartComponentOverrides(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
