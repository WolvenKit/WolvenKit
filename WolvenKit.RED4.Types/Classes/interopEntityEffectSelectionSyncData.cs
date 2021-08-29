using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopEntityEffectSelectionSyncData : RedBaseClass
	{
		private CName _effectName;
		private toolsEditorObjectIDPath _effectIDPath;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(1)] 
		[RED("effectIDPath")] 
		public toolsEditorObjectIDPath EffectIDPath
		{
			get => GetProperty(ref _effectIDPath);
			set => SetProperty(ref _effectIDPath, value);
		}
	}
}
