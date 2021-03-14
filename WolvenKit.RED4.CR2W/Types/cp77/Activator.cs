using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Activator : InteractiveMasterDevice
	{
		private CHandle<AnimFeature_SimpleDevice> _animFeature;
		private CInt32 _hitCount;
		private CHandle<entMeshComponent> _meshComponent;
		private CName _meshAppearence;
		private CName _meshAppearenceBreaking;
		private CName _meshAppearenceBroken;
		private CFloat _defaultDelay;
		private CFloat _yellowDelay;
		private CFloat _redDelay;

		[Ordinal(93)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_SimpleDevice> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_SimpleDevice>) CR2WTypeManager.Create("handle:AnimFeature_SimpleDevice", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get
			{
				if (_hitCount == null)
				{
					_hitCount = (CInt32) CR2WTypeManager.Create("Int32", "hitCount", cr2w, this);
				}
				return _hitCount;
			}
			set
			{
				if (_hitCount == value)
				{
					return;
				}
				_hitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("meshComponent")] 
		public CHandle<entMeshComponent> MeshComponent
		{
			get
			{
				if (_meshComponent == null)
				{
					_meshComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "meshComponent", cr2w, this);
				}
				return _meshComponent;
			}
			set
			{
				if (_meshComponent == value)
				{
					return;
				}
				_meshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("meshAppearence")] 
		public CName MeshAppearence
		{
			get
			{
				if (_meshAppearence == null)
				{
					_meshAppearence = (CName) CR2WTypeManager.Create("CName", "meshAppearence", cr2w, this);
				}
				return _meshAppearence;
			}
			set
			{
				if (_meshAppearence == value)
				{
					return;
				}
				_meshAppearence = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("meshAppearenceBreaking")] 
		public CName MeshAppearenceBreaking
		{
			get
			{
				if (_meshAppearenceBreaking == null)
				{
					_meshAppearenceBreaking = (CName) CR2WTypeManager.Create("CName", "meshAppearenceBreaking", cr2w, this);
				}
				return _meshAppearenceBreaking;
			}
			set
			{
				if (_meshAppearenceBreaking == value)
				{
					return;
				}
				_meshAppearenceBreaking = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("meshAppearenceBroken")] 
		public CName MeshAppearenceBroken
		{
			get
			{
				if (_meshAppearenceBroken == null)
				{
					_meshAppearenceBroken = (CName) CR2WTypeManager.Create("CName", "meshAppearenceBroken", cr2w, this);
				}
				return _meshAppearenceBroken;
			}
			set
			{
				if (_meshAppearenceBroken == value)
				{
					return;
				}
				_meshAppearenceBroken = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("defaultDelay")] 
		public CFloat DefaultDelay
		{
			get
			{
				if (_defaultDelay == null)
				{
					_defaultDelay = (CFloat) CR2WTypeManager.Create("Float", "defaultDelay", cr2w, this);
				}
				return _defaultDelay;
			}
			set
			{
				if (_defaultDelay == value)
				{
					return;
				}
				_defaultDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("yellowDelay")] 
		public CFloat YellowDelay
		{
			get
			{
				if (_yellowDelay == null)
				{
					_yellowDelay = (CFloat) CR2WTypeManager.Create("Float", "yellowDelay", cr2w, this);
				}
				return _yellowDelay;
			}
			set
			{
				if (_yellowDelay == value)
				{
					return;
				}
				_yellowDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("redDelay")] 
		public CFloat RedDelay
		{
			get
			{
				if (_redDelay == null)
				{
					_redDelay = (CFloat) CR2WTypeManager.Create("Float", "redDelay", cr2w, this);
				}
				return _redDelay;
			}
			set
			{
				if (_redDelay == value)
				{
					return;
				}
				_redDelay = value;
				PropertySet(this);
			}
		}

		public Activator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
