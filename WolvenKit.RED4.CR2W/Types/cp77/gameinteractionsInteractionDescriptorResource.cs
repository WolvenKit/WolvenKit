using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsInteractionDescriptorResource : CResource
	{
		private gameinteractionsCHotSpotDefinition _definition;

		[Ordinal(1)] 
		[RED("definition")] 
		public gameinteractionsCHotSpotDefinition Definition
		{
			get
			{
				if (_definition == null)
				{
					_definition = (gameinteractionsCHotSpotDefinition) CR2WTypeManager.Create("gameinteractionsCHotSpotDefinition", "definition", cr2w, this);
				}
				return _definition;
			}
			set
			{
				if (_definition == value)
				{
					return;
				}
				_definition = value;
				PropertySet(this);
			}
		}

		public gameinteractionsInteractionDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
