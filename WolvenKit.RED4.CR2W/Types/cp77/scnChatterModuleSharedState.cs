using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChatterModuleSharedState : ISerializable
	{
		private CArray<CHandle<scnChatter>> _chatterHistory;

		[Ordinal(0)] 
		[RED("chatterHistory")] 
		public CArray<CHandle<scnChatter>> ChatterHistory
		{
			get => GetProperty(ref _chatterHistory);
			set => SetProperty(ref _chatterHistory, value);
		}

		public scnChatterModuleSharedState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
