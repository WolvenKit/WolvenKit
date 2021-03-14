using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetrunnerControlPanelControllerPS : BasicDistractionDeviceControllerPS
	{
		private ComputerQuickHackData _factQuickHackSetup;
		private CBool _quickhackPerformed;

		[Ordinal(108)] 
		[RED("factQuickHackSetup")] 
		public ComputerQuickHackData FactQuickHackSetup
		{
			get
			{
				if (_factQuickHackSetup == null)
				{
					_factQuickHackSetup = (ComputerQuickHackData) CR2WTypeManager.Create("ComputerQuickHackData", "factQuickHackSetup", cr2w, this);
				}
				return _factQuickHackSetup;
			}
			set
			{
				if (_factQuickHackSetup == value)
				{
					return;
				}
				_factQuickHackSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("quickhackPerformed")] 
		public CBool QuickhackPerformed
		{
			get
			{
				if (_quickhackPerformed == null)
				{
					_quickhackPerformed = (CBool) CR2WTypeManager.Create("Bool", "quickhackPerformed", cr2w, this);
				}
				return _quickhackPerformed;
			}
			set
			{
				if (_quickhackPerformed == value)
				{
					return;
				}
				_quickhackPerformed = value;
				PropertySet(this);
			}
		}

		public NetrunnerControlPanelControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
