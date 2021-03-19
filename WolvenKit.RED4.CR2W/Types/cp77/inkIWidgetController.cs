using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkIWidgetController : IScriptable
	{
		private CName _audioMetadataName;

		[Ordinal(0)] 
		[RED("audioMetadataName")] 
		public CName AudioMetadataName
		{
			get => GetProperty(ref _audioMetadataName);
			set => SetProperty(ref _audioMetadataName, value);
		}

		public inkIWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
