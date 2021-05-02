using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetSaveDataLoadingScreen_NodeType : questIUIManagerNodeType
	{
		private TweakDBID _selectedLoading;

		[Ordinal(0)] 
		[RED("selectedLoading")] 
		public TweakDBID SelectedLoading
		{
			get => GetProperty(ref _selectedLoading);
			set => SetProperty(ref _selectedLoading, value);
		}

		public questSetSaveDataLoadingScreen_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
