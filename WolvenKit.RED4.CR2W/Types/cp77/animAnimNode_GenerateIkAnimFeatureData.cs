using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GenerateIkAnimFeatureData : animAnimNode_OnePoseInput
	{
		private CArray<animIKChainSettings> _ikChainSettings;

		[Ordinal(12)] 
		[RED("ikChainSettings")] 
		public CArray<animIKChainSettings> IkChainSettings
		{
			get => GetProperty(ref _ikChainSettings);
			set => SetProperty(ref _ikChainSettings, value);
		}

		public animAnimNode_GenerateIkAnimFeatureData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
