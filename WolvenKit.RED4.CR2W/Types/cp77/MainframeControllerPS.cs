using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MainframeControllerPS : BaseAnimatedDeviceControllerPS
	{
		private ComputerQuickHackData _factName;

		[Ordinal(108)] 
		[RED("factName")] 
		public ComputerQuickHackData FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (ComputerQuickHackData) CR2WTypeManager.Create("ComputerQuickHackData", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		public MainframeControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
