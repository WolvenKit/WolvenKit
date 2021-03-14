using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questClearForcedBehavioursNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _puppet;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		public questClearForcedBehavioursNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
