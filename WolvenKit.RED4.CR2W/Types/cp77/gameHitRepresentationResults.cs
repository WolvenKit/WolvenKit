using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResults : CVariable
	{
		private CArray<gameHitRepresentationResult> _sults;

		[Ordinal(0)] 
		[RED("sults")] 
		public CArray<gameHitRepresentationResult> Sults
		{
			get => GetProperty(ref _sults);
			set => SetProperty(ref _sults, value);
		}

		public gameHitRepresentationResults(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
