using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePersistentID : CVariable
	{
		private CUInt64 _entityHash;
		private CName _componentName;

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
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		public gamePersistentID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
