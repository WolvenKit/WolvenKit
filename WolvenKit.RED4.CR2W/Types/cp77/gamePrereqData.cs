using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqData : CVariable
	{
		private CBool _bAndValues;
		private CArray<gamePrereqCheckData> _prereqList;

		[Ordinal(0)] 
		[RED("bAndValues")] 
		public CBool BAndValues
		{
			get => GetProperty(ref _bAndValues);
			set => SetProperty(ref _bAndValues, value);
		}

		[Ordinal(1)] 
		[RED("prereqList")] 
		public CArray<gamePrereqCheckData> PrereqList
		{
			get => GetProperty(ref _prereqList);
			set => SetProperty(ref _prereqList, value);
		}

		public gamePrereqData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
