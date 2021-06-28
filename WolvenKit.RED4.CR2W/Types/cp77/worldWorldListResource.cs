using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldListResource : CResource
	{
		private CArray<worldWorldListResourceEntry> _worlds;

		[Ordinal(1)] 
		[RED("worlds")] 
		public CArray<worldWorldListResourceEntry> Worlds
		{
			get => GetProperty(ref _worlds);
			set => SetProperty(ref _worlds, value);
		}

		public worldWorldListResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
