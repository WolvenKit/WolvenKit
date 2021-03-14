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
			get
			{
				if (_sequences == null)
				{
					_sequences = (CArray<CHandle<inkanimSequence>>) CR2WTypeManager.Create("array:handle:inkanimSequence", "sequences", cr2w, this);
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

		public inkanimAnimationLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
