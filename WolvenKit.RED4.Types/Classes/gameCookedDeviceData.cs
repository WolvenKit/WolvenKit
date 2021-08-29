using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCookedDeviceData : RedBaseClass
	{
		private CName _className;
		private CArray<CUInt64> _parents;
		private CArray<CUInt64> _children;
		private Vector3 _nodePosition;

		[Ordinal(0)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(1)] 
		[RED("parents")] 
		public CArray<CUInt64> Parents
		{
			get => GetProperty(ref _parents);
			set => SetProperty(ref _parents, value);
		}

		[Ordinal(2)] 
		[RED("children")] 
		public CArray<CUInt64> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(3)] 
		[RED("nodePosition")] 
		public Vector3 NodePosition
		{
			get => GetProperty(ref _nodePosition);
			set => SetProperty(ref _nodePosition, value);
		}
	}
}
