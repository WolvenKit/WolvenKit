using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPuppeteerNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questPuppetsEffector> _effector;
		private gameEntityReference _reference;

		[Ordinal(2)] 
		[RED("effector")] 
		public CHandle<questPuppetsEffector> Effector
		{
			get
			{
				if (_effector == null)
				{
					_effector = (CHandle<questPuppetsEffector>) CR2WTypeManager.Create("handle:questPuppetsEffector", "effector", cr2w, this);
				}
				return _effector;
			}
			set
			{
				if (_effector == value)
				{
					return;
				}
				_effector = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reference")] 
		public gameEntityReference Reference
		{
			get
			{
				if (_reference == null)
				{
					_reference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "reference", cr2w, this);
				}
				return _reference;
			}
			set
			{
				if (_reference == value)
				{
					return;
				}
				_reference = value;
				PropertySet(this);
			}
		}

		public questPuppeteerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
