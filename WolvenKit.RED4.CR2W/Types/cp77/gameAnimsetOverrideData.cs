using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAnimsetOverrideData : CVariable
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

		public gameAnimsetOverrideData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
