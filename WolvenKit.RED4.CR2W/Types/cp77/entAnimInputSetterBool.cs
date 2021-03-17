using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterBool : entAnimInputSetter
	{
		private CBool _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public entAnimInputSetterBool(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
