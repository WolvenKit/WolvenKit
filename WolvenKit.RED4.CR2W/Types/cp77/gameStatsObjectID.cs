using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsObjectID : CVariable
	{
		private CUInt64 _entityHash;
		private CEnum<gameStatIDType> _idType;

		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get
			{
				if (_entityHash == null)
				{
					_entityHash = (CUInt64) CR2WTypeManager.Create("Uint64", "entityHash", cr2w, this);
				}
				return _entityHash;
			}
			set
			{
				if (_entityHash == value)
				{
					return;
				}
				_entityHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("idType")] 
		public CEnum<gameStatIDType> IdType
		{
			get
			{
				if (_idType == null)
				{
					_idType = (CEnum<gameStatIDType>) CR2WTypeManager.Create("gameStatIDType", "idType", cr2w, this);
				}
				return _idType;
			}
			set
			{
				if (_idType == value)
				{
					return;
				}
				_idType = value;
				PropertySet(this);
			}
		}

		public gameStatsObjectID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
