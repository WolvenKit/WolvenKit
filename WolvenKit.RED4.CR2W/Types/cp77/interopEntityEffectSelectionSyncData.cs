using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopEntityEffectSelectionSyncData : CVariable
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

		public interopEntityEffectSelectionSyncData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
