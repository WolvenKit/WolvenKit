using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeSaveEntityData : CVariable
	{
		private entEntityID _entityId;
		private gameGodModeEntityData _data;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get
			{
				if (_entityId == null)
				{
					_entityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityId", cr2w, this);
				}
				return _entityId;
			}
			set
			{
				if (_entityId == value)
				{
					return;
				}
				_entityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameGodModeEntityData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (gameGodModeEntityData) CR2WTypeManager.Create("gameGodModeEntityData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameGodModeSaveEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
