using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redStageMessage : RedBaseClass
	{
		private CUInt32 _parent;
		private CBool _reset;
		private CArray<CString> _names;
		private CArray<CUInt32> _ids;

		[Ordinal(0)] 
		[RED("parent")] 
		public CUInt32 Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}

		[Ordinal(1)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(2)] 
		[RED("names")] 
		public CArray<CString> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(3)] 
		[RED("ids")] 
		public CArray<CUInt32> Ids
		{
			get => GetProperty(ref _ids);
			set => SetProperty(ref _ids, value);
		}

		public redStageMessage()
		{
			_parent = 4294967295;
		}
	}
}
