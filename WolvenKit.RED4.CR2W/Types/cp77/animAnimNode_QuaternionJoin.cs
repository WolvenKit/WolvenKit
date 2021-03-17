using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionJoin : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animQuaternionLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		public animAnimNode_QuaternionJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
