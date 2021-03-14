using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestSirenEvent : redEvent
	{
		private CBool _lights;
		private CBool _sounds;

		[Ordinal(0)] 
		[RED("lights")] 
		public CBool Lights
		{
			get
			{
				if (_lights == null)
				{
					_lights = (CBool) CR2WTypeManager.Create("Bool", "lights", cr2w, this);
				}
				return _lights;
			}
			set
			{
				if (_lights == value)
				{
					return;
				}
				_lights = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sounds")] 
		public CBool Sounds
		{
			get
			{
				if (_sounds == null)
				{
					_sounds = (CBool) CR2WTypeManager.Create("Bool", "sounds", cr2w, this);
				}
				return _sounds;
			}
			set
			{
				if (_sounds == value)
				{
					return;
				}
				_sounds = value;
				PropertySet(this);
			}
		}

		public VehicleQuestSirenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
