using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questManageCollision_NodeTypeParams : RedBaseClass
	{
		private NodeRef _objectRef;
		private CBool _enableCollision;
		private CBool _enableQueries;
		private CArray<CName> _components;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get => GetProperty(ref _enableCollision);
			set => SetProperty(ref _enableCollision, value);
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get => GetProperty(ref _enableQueries);
			set => SetProperty(ref _enableQueries, value);
		}

		[Ordinal(3)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		public questManageCollision_NodeTypeParams()
		{
			_enableQueries = true;
		}
	}
}
