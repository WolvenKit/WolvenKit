using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameForceVisionModuleQuestEvent : redEvent
	{
		private CName _moduleName;
		private CArray<CName> _meshComponentNames;

		[Ordinal(0)] 
		[RED("moduleName")] 
		public CName ModuleName
		{
			get => GetProperty(ref _moduleName);
			set => SetProperty(ref _moduleName, value);
		}

		[Ordinal(1)] 
		[RED("meshComponentNames")] 
		public CArray<CName> MeshComponentNames
		{
			get => GetProperty(ref _meshComponentNames);
			set => SetProperty(ref _meshComponentNames, value);
		}
	}
}
