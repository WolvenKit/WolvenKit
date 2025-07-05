using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SVFXOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("vfxResource")] 
		public gameFxResource VfxResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(2)] 
		[RED("shouldPersist")] 
		public CBool ShouldPersist
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("size")] 
		public CFloat Size
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(5)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EEffectOperationType>>();
			set => SetPropertyValue<CEnum<EEffectOperationType>>(value);
		}

		public SVFXOperationData()
		{
			VfxResource = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
