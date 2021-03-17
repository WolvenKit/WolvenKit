using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneDefaults : audioAudioMetadata
	{
		private CArray<audioAudSimpleParameter> _parameters;

		[Ordinal(1)] 
		[RED("parameters")] 
		public CArray<audioAudSimpleParameter> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		public audioAudioSceneDefaults(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
