using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDebugColoring_CollisionMeshes : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _prefabColor;
		private CColor _collisionMeshColor;

		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get => GetProperty(ref _defaultColor);
			set => SetProperty(ref _defaultColor, value);
		}

		[Ordinal(1)] 
		[RED("prefabColor")] 
		public CColor PrefabColor
		{
			get => GetProperty(ref _prefabColor);
			set => SetProperty(ref _prefabColor, value);
		}

		[Ordinal(2)] 
		[RED("collisionMeshColor")] 
		public CColor CollisionMeshColor
		{
			get => GetProperty(ref _collisionMeshColor);
			set => SetProperty(ref _collisionMeshColor, value);
		}
	}
}
