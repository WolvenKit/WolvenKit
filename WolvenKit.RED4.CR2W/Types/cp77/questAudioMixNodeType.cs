using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioMixNodeType : questIAudioNodeType
	{
		private CName _mixSignpost;

		[Ordinal(0)] 
		[RED("mixSignpost")] 
		public CName MixSignpost
		{
			get => GetProperty(ref _mixSignpost);
			set => SetProperty(ref _mixSignpost, value);
		}

		public questAudioMixNodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
