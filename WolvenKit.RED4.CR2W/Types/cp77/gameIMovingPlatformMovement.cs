using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIMovingPlatformMovement : IScriptable
	{
		private gameIMovingPlatformMovementInitData _initData;

		[Ordinal(0)] 
		[RED("initData")] 
		public gameIMovingPlatformMovementInitData InitData
		{
			get
			{
				if (_initData == null)
				{
					_initData = (gameIMovingPlatformMovementInitData) CR2WTypeManager.Create("gameIMovingPlatformMovementInitData", "initData", cr2w, this);
				}
				return _initData;
			}
			set
			{
				if (_initData == value)
				{
					return;
				}
				_initData = value;
				PropertySet(this);
			}
		}

		public gameIMovingPlatformMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
