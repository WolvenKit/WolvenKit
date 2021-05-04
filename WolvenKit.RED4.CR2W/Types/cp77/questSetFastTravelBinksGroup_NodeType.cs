using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFastTravelBinksGroup_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _selectedBinkDataGroup;

		[Ordinal(0)] 
		[RED("selectedBinkDataGroup")] 
		public TweakDBID SelectedBinkDataGroup
		{
			get => GetProperty(ref _selectedBinkDataGroup);
			set => SetProperty(ref _selectedBinkDataGroup, value);
		}

		public questSetFastTravelBinksGroup_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
