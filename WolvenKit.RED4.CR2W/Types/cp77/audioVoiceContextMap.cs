using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVoiceContextMap : audioAudioMetadata
	{
		private CArray<CName> _includes;
		private CArray<audioVoiceContextMapItem> _contexts;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("contexts")] 
		public CArray<audioVoiceContextMapItem> Contexts
		{
			get => GetProperty(ref _contexts);
			set => SetProperty(ref _contexts, value);
		}

		public audioVoiceContextMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
