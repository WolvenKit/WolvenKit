using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAreaVolume : gameObject
	{
		private gameAreaData _areaData;

		[Ordinal(40)] 
		[RED("areaData")] 
		public gameAreaData AreaData
		{
			get
			{
				if (_areaData == null)
				{
					_areaData = (gameAreaData) CR2WTypeManager.Create("gameAreaData", "areaData", cr2w, this);
				}
				return _areaData;
			}
			set
			{
				if (_areaData == value)
				{
					return;
				}
				_areaData = value;
				PropertySet(this);
			}
		}

		public gameAreaVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
