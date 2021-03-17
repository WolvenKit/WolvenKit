using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetVar_NodeType : questIFactsDBManagerNodeType
	{
		private CString _factName;
		private CInt32 _value;
		private CBool _setExactValue;

		[Ordinal(0)] 
		[RED("factName")] 
		public CString FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("setExactValue")] 
		public CBool SetExactValue
		{
			get => GetProperty(ref _setExactValue);
			set => SetProperty(ref _setExactValue, value);
		}

		public questSetVar_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
