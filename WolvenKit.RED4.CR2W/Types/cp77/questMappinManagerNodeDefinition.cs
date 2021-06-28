using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<gameJournalPath> _path;
		private CBool _disablePreviousMappins;

		[Ordinal(2)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(3)] 
		[RED("disablePreviousMappins")] 
		public CBool DisablePreviousMappins
		{
			get => GetProperty(ref _disablePreviousMappins);
			set => SetProperty(ref _disablePreviousMappins, value);
		}

		public questMappinManagerNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
