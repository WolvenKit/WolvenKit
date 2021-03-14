using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossingLight : TrafficLight
	{
		private CBool _audioLightIsGreen;

		[Ordinal(89)] 
		[RED("audioLightIsGreen")] 
		public CBool AudioLightIsGreen
		{
			get
			{
				if (_audioLightIsGreen == null)
				{
					_audioLightIsGreen = (CBool) CR2WTypeManager.Create("Bool", "audioLightIsGreen", cr2w, this);
				}
				return _audioLightIsGreen;
			}
			set
			{
				if (_audioLightIsGreen == value)
				{
					return;
				}
				_audioLightIsGreen = value;
				PropertySet(this);
			}
		}

		public CrossingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
