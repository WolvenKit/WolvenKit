using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerSkillCheckLogicController : inkWidgetLogicController
	{
		private CName _scannerSkillCheckItemName;
		private CArray<CWeakHandle<inkWidget>> _skillCheckObjects;
		private CWeakHandle<inkCompoundWidget> _root;

		[Ordinal(1)] 
		[RED("ScannerSkillCheckItemName")] 
		public CName ScannerSkillCheckItemName
		{
			get => GetProperty(ref _scannerSkillCheckItemName);
			set => SetProperty(ref _scannerSkillCheckItemName, value);
		}

		[Ordinal(2)] 
		[RED("SkillCheckObjects")] 
		public CArray<CWeakHandle<inkWidget>> SkillCheckObjects
		{
			get => GetProperty(ref _skillCheckObjects);
			set => SetProperty(ref _skillCheckObjects, value);
		}

		[Ordinal(3)] 
		[RED("Root")] 
		public CWeakHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}
	}
}
