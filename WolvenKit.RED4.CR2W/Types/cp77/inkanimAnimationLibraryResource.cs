using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimAnimationLibraryResource : CResource
	{
		private CArray<CHandle<inkanimSequence>> _sequences;

		[Ordinal(1)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get => GetProperty(ref _sequences);
			set => SetProperty(ref _sequences, value);
		}

		public inkanimAnimationLibraryResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
