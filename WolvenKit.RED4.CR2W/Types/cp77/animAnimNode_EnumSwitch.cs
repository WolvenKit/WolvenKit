using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_EnumSwitch : animAnimNode_InputSwitch
	{
		private CName _enumName;

		[Ordinal(18)] 
		[RED("enumName")] 
		public CName EnumName
		{
			get => GetProperty(ref _enumName);
			set => SetProperty(ref _enumName, value);
		}

		public animAnimNode_EnumSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
