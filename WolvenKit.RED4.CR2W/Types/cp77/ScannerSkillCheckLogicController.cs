using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		private CName _scannerSkillCheckItemName;
		private CArray<wCHandle<inkWidget>> _skillCheckObjects;
		private wCHandle<inkCompoundWidget> _root;

		[Ordinal(1)] 
		[RED("ScannerSkillCheckItemName")] 
		public CName ScannerSkillCheckItemName
		{
			get => GetProperty(ref _scannerSkillCheckItemName);
			set => SetProperty(ref _scannerSkillCheckItemName, value);
		}

		[Ordinal(2)] 
		[RED("SkillCheckObjects")] 
		public CArray<wCHandle<inkWidget>> SkillCheckObjects
		{
			get => GetProperty(ref _skillCheckObjects);
			set => SetProperty(ref _skillCheckObjects, value);
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		public ScannerSkillCheckLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
