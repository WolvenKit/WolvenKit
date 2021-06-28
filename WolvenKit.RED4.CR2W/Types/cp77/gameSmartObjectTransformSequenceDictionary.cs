using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformSequenceDictionary : ISerializable
	{
		private CArray<gameSmartObjectTransformSequenceDictionaryEntry> _sequences;

		[Ordinal(0)] 
		[RED("sequences")] 
		public CArray<gameSmartObjectTransformSequenceDictionaryEntry> Sequences
		{
			get => GetProperty(ref _sequences);
			set => SetProperty(ref _sequences, value);
		}

		public gameSmartObjectTransformSequenceDictionary(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
