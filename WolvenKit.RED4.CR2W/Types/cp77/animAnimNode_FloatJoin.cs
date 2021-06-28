using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatJoin : animAnimNode_FloatValue
	{
		private animFloatLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animFloatLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}

		public animAnimNode_FloatJoin(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
