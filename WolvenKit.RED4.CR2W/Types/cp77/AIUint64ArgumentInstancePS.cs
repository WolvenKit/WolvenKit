using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUint64ArgumentInstancePS : AIArgumentInstancePS
	{
		private CUInt64 _value;

		[Ordinal(1)] 
		[RED("value")] 
		public CUInt64 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		public AIUint64ArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
