using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SVFXOperationData : CVariable
	{
		private CName _vfxName;
		private gameFxResource _vfxResource;
		private CBool _shouldPersist;
		private CFloat _size;
		private NodeRef _nodeRef;
		private CEnum<EEffectOperationType> _operationType;

		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get
			{
				if (_vfxName == null)
				{
					_vfxName = (CName) CR2WTypeManager.Create("CName", "vfxName", cr2w, this);
				}
				return _vfxName;
			}
			set
			{
				if (_vfxName == value)
				{
					return;
				}
				_vfxName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get
			{
				if (_vfxResource == null)
				{
					_vfxResource = (gameFxResource) CR2WTypeManager.Create("gameFxResource", "vfxResource", cr2w, this);
				}
				return _vfxResource;
			}
			set
			{
				if (_vfxResource == value)
				{
					return;
				}
				_vfxResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldPersist")] 
		public CBool ShouldPersist
		{
			get
			{
				if (_shouldPersist == null)
				{
					_shouldPersist = (CBool) CR2WTypeManager.Create("Bool", "shouldPersist", cr2w, this);
				}
				return _shouldPersist;
			}
			set
			{
				if (_shouldPersist == value)
				{
					return;
				}
				_shouldPersist = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CFloat Size
		{
			get
			{
				if (_size == null)
				{
					_size = (CFloat) CR2WTypeManager.Create("Float", "size", cr2w, this);
				}
				return _size;
			}
			set
			{
				if (_size == value)
				{
					return;
				}
				_size = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EEffectOperationType>) CR2WTypeManager.Create("EEffectOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		public SVFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
