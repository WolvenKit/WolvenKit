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
			get
			{
				if (_sequences == null)
				{
					_sequences = (CArray<gameSmartObjectTransformSequenceDictionaryEntry>) CR2WTypeManager.Create("array:gameSmartObjectTransformSequenceDictionaryEntry", "sequences", cr2w, this);
				}
				return _sequences;
			}
			set
			{
				if (_sequences == value)
				{
					return;
				}
				_sequences = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectTransformSequenceDictionary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
