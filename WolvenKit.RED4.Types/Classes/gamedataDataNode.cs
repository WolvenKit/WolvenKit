using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataDataNode : ISerializable
	{
		private CEnum<gamedataDataNodeType> _nodeType;
		private CString _fileName;
		private CWeakHandle<gamedataDataNode> _parent;

		[Ordinal(0)] 
		[RED("nodeType")] 
		public CEnum<gamedataDataNodeType> NodeType
		{
			get => GetProperty(ref _nodeType);
			set => SetProperty(ref _nodeType, value);
		}

		[Ordinal(1)] 
		[RED("fileName")] 
		public CString FileName
		{
			get => GetProperty(ref _fileName);
			set => SetProperty(ref _fileName, value);
		}

		[Ordinal(2)] 
		[RED("parent")] 
		public CWeakHandle<gamedataDataNode> Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}
	}
}
