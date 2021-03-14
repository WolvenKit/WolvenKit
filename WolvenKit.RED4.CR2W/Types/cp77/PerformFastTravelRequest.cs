using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerformFastTravelRequest : gameScriptableSystemRequest
	{
		private CHandle<gameFastTravelPointData> _pointData;
		private wCHandle<gameObject> _player;

		[Ordinal(0)] 
		[RED("pointData")] 
		public CHandle<gameFastTravelPointData> PointData
		{
			get
			{
				if (_pointData == null)
				{
					_pointData = (CHandle<gameFastTravelPointData>) CR2WTypeManager.Create("handle:gameFastTravelPointData", "pointData", cr2w, this);
				}
				return _pointData;
			}
			set
			{
				if (_pointData == value)
				{
					return;
				}
				_pointData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		public PerformFastTravelRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
