using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Valued : animAnimEvent
	{
		private CFloat _value;

		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public animAnimEvent_Valued(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
