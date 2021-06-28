using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereq : gameIPrereq
	{
		private CEnum<gameAggregationType> _aggregationType;
		private CArray<CHandle<gameIPrereq>> _nestedPrereqs;

		[Ordinal(0)] 
		[RED("aggregationType")] 
		public CEnum<gameAggregationType> AggregationType
		{
			get => GetProperty(ref _aggregationType);
			set => SetProperty(ref _aggregationType, value);
		}

		[Ordinal(1)] 
		[RED("nestedPrereqs")] 
		public CArray<CHandle<gameIPrereq>> NestedPrereqs
		{
			get => GetProperty(ref _nestedPrereqs);
			set => SetProperty(ref _nestedPrereqs, value);
		}

		public gameMultiPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
