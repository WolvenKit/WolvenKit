using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAnimsetOverrideData : RedBaseClass
	{
		private CUInt64 _animsetHash;
		private CArray<CName> _variables;

		[Ordinal(0)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get => GetProperty(ref _animsetHash);
			set => SetProperty(ref _animsetHash, value);
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}
	}
}
