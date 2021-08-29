using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNodeCollisionMapArrayElement : RedBaseClass
	{
		private NodeRef _objectRef;
		private CArray<questComponentCollisionMapArrayElement> _componentsCollisionMapArray;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("componentsCollisionMapArray")] 
		public CArray<questComponentCollisionMapArrayElement> ComponentsCollisionMapArray
		{
			get => GetProperty(ref _componentsCollisionMapArray);
			set => SetProperty(ref _componentsCollisionMapArray, value);
		}
	}
}
