using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariable : ISerializable
	{
		private CUInt16 _id;
		private CName _readableName;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt16) CR2WTypeManager.Create("Uint16", "id", cr2w, this);
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
		[RED("readableName")] 
		public CName ReadableName
		{
			get
			{
				if (_readableName == null)
				{
					_readableName = (CName) CR2WTypeManager.Create("CName", "readableName", cr2w, this);
				}
				return _readableName;
			}
			set
			{
				if (_readableName == value)
				{
					return;
				}
				_readableName = value;
				PropertySet(this);
			}
		}

		public LibTreeDefTreeVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
