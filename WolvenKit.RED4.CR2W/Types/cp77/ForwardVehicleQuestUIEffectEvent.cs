using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardVehicleQuestUIEffectEvent : redEvent
	{
		private CBool _glitch;
		private CBool _panamVehicleStartup;

		[Ordinal(0)] 
		[RED("glitch")] 
		public CBool Glitch
		{
			get
			{
				if (_glitch == null)
				{
					_glitch = (CBool) CR2WTypeManager.Create("Bool", "glitch", cr2w, this);
				}
				return _glitch;
			}
			set
			{
				if (_glitch == value)
				{
					return;
				}
				_glitch = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("panamVehicleStartup")] 
		public CBool PanamVehicleStartup
		{
			get
			{
				if (_panamVehicleStartup == null)
				{
					_panamVehicleStartup = (CBool) CR2WTypeManager.Create("Bool", "panamVehicleStartup", cr2w, this);
				}
				return _panamVehicleStartup;
			}
			set
			{
				if (_panamVehicleStartup == value)
				{
					return;
				}
				_panamVehicleStartup = value;
				PropertySet(this);
			}
		}

		public ForwardVehicleQuestUIEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
