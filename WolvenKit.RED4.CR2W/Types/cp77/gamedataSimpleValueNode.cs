using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataSimpleValueNode : gamedataValueDataNode
	{
		private CEnum<gamedataSimpleValueNodeValueType> _type;
		private CString _data;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataSimpleValueNodeValueType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CString Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gamedataSimpleValueNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
