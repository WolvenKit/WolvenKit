using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerChoiceTokenNodeDefinition : questSignalStoppingNodeDefinition
	{
		private questMultiplayerChoiceTokenParams _params;

		[Ordinal(2)] 
		[RED("params")] 
		public questMultiplayerChoiceTokenParams Params
		{
			get
			{
				if (_params == null)
				{
					_params = (questMultiplayerChoiceTokenParams) CR2WTypeManager.Create("questMultiplayerChoiceTokenParams", "params", cr2w, this);
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

		public questMultiplayerChoiceTokenNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
