using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataDataNode : ISerializable
	{
		private CEnum<gamedataDataNodeType> _nodeType;
		private CString _fileName;
		private wCHandle<gamedataDataNode> _parent;

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
		public wCHandle<gamedataDataNode> Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		public gamedataDataNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
