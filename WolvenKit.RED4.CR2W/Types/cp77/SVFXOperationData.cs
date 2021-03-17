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
			get => GetProperty(ref _vfxName);
			set => SetProperty(ref _vfxName, value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetProperty(ref _vfxResource);
			set => SetProperty(ref _vfxResource, value);
		}

		[Ordinal(2)] 
		[RED("shouldPersist")] 
		public CBool ShouldPersist
		{
			get => GetProperty(ref _shouldPersist);
			set => SetProperty(ref _shouldPersist, value);
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CFloat Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(5)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		public SVFXOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
