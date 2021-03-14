using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleNodeCommandDefinition : questAICommandNodeBase
	{
		private gameEntityReference _vehicle;
		private CHandle<questVehicleCommandParams> _commandParams;

		[Ordinal(2)] 
		[RED("vehicle")] 
		public gameEntityReference Vehicle
		{
			get
			{
				if (_vehicle == null)
				{
					_vehicle = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicle", cr2w, this);
				}
				return _vehicle;
			}
			set
			{
				if (_vehicle == value)
				{
					return;
				}
				_vehicle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questVehicleCommandParams> CommandParams
		{
			get
			{
				if (_commandParams == null)
				{
					_commandParams = (CHandle<questVehicleCommandParams>) CR2WTypeManager.Create("handle:questVehicleCommandParams", "commandParams", cr2w, this);
				}
				return _commandParams;
			}
			set
			{
				if (_commandParams == value)
				{
					return;
				}
				_commandParams = value;
				PropertySet(this);
			}
		}

		public questVehicleNodeCommandDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
