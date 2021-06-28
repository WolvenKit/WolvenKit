using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerFaction : ScannerChunk
	{
		private CString _faction;

		[Ordinal(0)] 
		[RED("faction")] 
		public CString Faction
		{
			get => GetProperty(ref _faction);
			set => SetProperty(ref _faction, value);
		}

		public ScannerFaction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
