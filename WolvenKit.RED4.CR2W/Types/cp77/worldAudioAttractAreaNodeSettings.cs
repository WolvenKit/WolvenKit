using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioAttractAreaNodeSettings : CVariable
	{
		private CName _metadataName;

		[Ordinal(0)] 
		[RED("metadataName")] 
		public CName MetadataName
		{
			get => GetProperty(ref _metadataName);
			set => SetProperty(ref _metadataName, value);
		}

		public worldAudioAttractAreaNodeSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
