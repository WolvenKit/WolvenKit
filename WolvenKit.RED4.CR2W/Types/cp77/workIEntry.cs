using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workIEntry : ISerializable
	{
		private workWorkEntryId _id;
		private CUInt32 _flags;

		[Ordinal(0)] 
		[RED("id")] 
		public workWorkEntryId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "id", cr2w, this);
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

		[Ordinal(1)] 
		[RED("flags")] 
		public CUInt32 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt32) CR2WTypeManager.Create("Uint32", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public workIEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
