using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanNPCRun : AIbehaviorconditionScript
	{
		private CInt32 _maxRunners;

		[Ordinal(0)] 
		[RED("maxRunners")] 
		public CInt32 MaxRunners
		{
			get => GetProperty(ref _maxRunners);
			set => SetProperty(ref _maxRunners, value);
		}

		public CanNPCRun(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
