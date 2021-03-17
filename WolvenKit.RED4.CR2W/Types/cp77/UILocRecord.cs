using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UILocRecord : CVariable
	{
		private CName _tag;
		private CString _value;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CString Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public UILocRecord(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
