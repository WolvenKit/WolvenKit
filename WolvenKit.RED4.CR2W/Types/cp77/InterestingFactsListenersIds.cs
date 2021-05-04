using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InterestingFactsListenersIds : CVariable
	{
		private CUInt32 _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CUInt32 Zone
		{
			get => GetProperty(ref _zone);
			set => SetProperty(ref _zone, value);
		}

		public InterestingFactsListenersIds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
