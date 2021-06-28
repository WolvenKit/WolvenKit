using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageToken_Location : toolsIMessageToken
	{
		private CHandle<toolsIMessageLocation> _location;

		[Ordinal(0)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		public toolsMessageToken_Location(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
