using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleport_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _entityReference;
		private questTeleportPuppetParams _params;

		[Ordinal(0)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("params")] 
		public questTeleportPuppetParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (questTeleportPuppetParams) CR2WTypeManager.Create("questTeleportPuppetParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questTeleport_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
