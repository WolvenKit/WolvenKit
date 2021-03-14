using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectTransformSequenceDictionaryEntry : CVariable
	{
		private CArray<CUInt16> _sequence;
		private CUInt8 _id;

		[Ordinal(0)] 
		[RED("sequence")] 
		public CArray<CUInt16> Sequence
		{
			get
			{
				if (_sequence == null)
				{
					_sequence = (CArray<CUInt16>) CR2WTypeManager.Create("array:Uint16", "sequence", cr2w, this);
				}
				return _sequence;
			}
			set
			{
				if (_sequence == value)
				{
					return;
				}
				_sequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt8 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt8) CR2WTypeManager.Create("Uint8", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectTransformSequenceDictionaryEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
