using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWorldListResourceEntry : CVariable
	{
		private raRef<CResource> _world;
		private raRef<CResource> _streamingWorld;
		private CString _worldName;

		[Ordinal(0)] 
		[RED("world")] 
		public raRef<CResource> World
		{
			get => GetProperty(ref _world);
			set => SetProperty(ref _world, value);
		}

		[Ordinal(1)] 
		[RED("streamingWorld")] 
		public raRef<CResource> StreamingWorld
		{
			get => GetProperty(ref _streamingWorld);
			set => SetProperty(ref _streamingWorld, value);
		}

		[Ordinal(2)] 
		[RED("worldName")] 
		public CString WorldName
		{
			get => GetProperty(ref _worldName);
			set => SetProperty(ref _worldName, value);
		}

		public worldWorldListResourceEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
