using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataComplexValueNode : gamedataValueDataNode
	{
		private CArray<CString> _data;

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CString> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public gamedataComplexValueNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
