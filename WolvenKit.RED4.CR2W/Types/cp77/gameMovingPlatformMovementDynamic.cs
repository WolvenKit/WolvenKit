using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMovementDynamic : gameIMovingPlatformMovementPointToPoint
	{
		private CName _curveName;

		[Ordinal(1)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get
			{
				if (_curveName == null)
				{
					_curveName = (CName) CR2WTypeManager.Create("CName", "curveName", cr2w, this);
				}
				return _curveName;
			}
			set
			{
				if (_curveName == value)
				{
					return;
				}
				_curveName = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatformMovementDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
