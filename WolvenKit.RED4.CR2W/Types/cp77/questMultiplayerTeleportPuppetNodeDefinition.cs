using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetNodeDefinition : questSignalStoppingNodeDefinition
	{
		private questMultiplayerTeleportPuppetParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerTeleportPuppetParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (questMultiplayerTeleportPuppetParams) CR2WTypeManager.Create("questMultiplayerTeleportPuppetParams", "params", cr2w, this);
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

		public questMultiplayerTeleportPuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
