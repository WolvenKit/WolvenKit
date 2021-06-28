using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHitRepresentationResult : CVariable
	{
		private gameQueryResult _sult;
		private entEntityID _tityID;

		[Ordinal(0)] 
		[RED("sult")] 
		public gameQueryResult Sult
		{
			get => GetProperty(ref _sult);
			set => SetProperty(ref _sult, value);
		}

		[Ordinal(1)] 
		[RED("tityID")] 
		public entEntityID TityID
		{
			get => GetProperty(ref _tityID);
			set => SetProperty(ref _tityID, value);
		}

		public gameHitRepresentationResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
