using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAICommandNodeFunction : RedBaseClass
	{
		private CUInt32 _order;
		private CName _nodeType;
		private CName _commandCategory;
		private CString _friendlyName;
		private CName _paramsType;
		private CColor _nodeColor;

		[Ordinal(0)] 
		[RED("order")] 
		public CUInt32 Order
		{
			get => GetProperty(ref _order);
			set => SetProperty(ref _order, value);
		}

		[Ordinal(1)] 
		[RED("nodeType")] 
		public CName NodeType
		{
			get => GetProperty(ref _nodeType);
			set => SetProperty(ref _nodeType, value);
		}

		[Ordinal(2)] 
		[RED("commandCategory")] 
		public CName CommandCategory
		{
			get => GetProperty(ref _commandCategory);
			set => SetProperty(ref _commandCategory, value);
		}

		[Ordinal(3)] 
		[RED("friendlyName")] 
		public CString FriendlyName
		{
			get => GetProperty(ref _friendlyName);
			set => SetProperty(ref _friendlyName, value);
		}

		[Ordinal(4)] 
		[RED("paramsType")] 
		public CName ParamsType
		{
			get => GetProperty(ref _paramsType);
			set => SetProperty(ref _paramsType, value);
		}

		[Ordinal(5)] 
		[RED("nodeColor")] 
		public CColor NodeColor
		{
			get => GetProperty(ref _nodeColor);
			set => SetProperty(ref _nodeColor, value);
		}
	}
}
