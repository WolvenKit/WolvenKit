using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChatter : CVariable
	{
		private CUInt16 _id;
		private wCHandle<scnVoicesetComponent> _voicesetComponent;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("voicesetComponent")] 
		public wCHandle<scnVoicesetComponent> VoicesetComponent
		{
			get => GetProperty(ref _voicesetComponent);
			set => SetProperty(ref _voicesetComponent, value);
		}

		public scnChatter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
