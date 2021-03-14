using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FactQuickHack : ActionBool
	{
		private ComputerQuickHackData _factProperties;

		[Ordinal(25)] 
		[RED("factProperties")] 
		public ComputerQuickHackData FactProperties
		{
			get
			{
				if (_factProperties == null)
				{
					_factProperties = (ComputerQuickHackData) CR2WTypeManager.Create("ComputerQuickHackData", "factProperties", cr2w, this);
				}
				return _factProperties;
			}
			set
			{
				if (_factProperties == value)
				{
					return;
				}
				_factProperties = value;
				PropertySet(this);
			}
		}

		public FactQuickHack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
