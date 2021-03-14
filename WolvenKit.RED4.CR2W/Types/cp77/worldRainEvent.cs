using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRainEvent : redEvent
	{
		private CEnum<worldRainIntensity> _rainIntensity;

		[Ordinal(0)] 
		[RED("rainIntensity")] 
		public CEnum<worldRainIntensity> RainIntensity
		{
			get
			{
				if (_rainIntensity == null)
				{
					_rainIntensity = (CEnum<worldRainIntensity>) CR2WTypeManager.Create("worldRainIntensity", "rainIntensity", cr2w, this);
				}
				return _rainIntensity;
			}
			set
			{
				if (_rainIntensity == value)
				{
					return;
				}
				_rainIntensity = value;
				PropertySet(this);
			}
		}

		public worldRainEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
