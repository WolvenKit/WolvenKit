using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportVehicleNodeDefinition : questDisableableNodeDefinition
	{
		private gameEntityReference _entityReference;
		private questTeleportPuppetParams _params;
		private CBool _resetVelocities;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("resetVelocities")] 
		public CBool ResetVelocities
		{
			get
			{
				if (_resetVelocities == null)
				{
					_resetVelocities = (CBool) CR2WTypeManager.Create("Bool", "resetVelocities", cr2w, this);
				}
				return _resetVelocities;
			}
			set
			{
				if (_resetVelocities == value)
				{
					return;
				}
				_resetVelocities = value;
				PropertySet(this);
			}
		}

		public questTeleportVehicleNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
