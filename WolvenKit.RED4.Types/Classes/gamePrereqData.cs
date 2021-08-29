using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePrereqData : RedBaseClass
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
	}
}
