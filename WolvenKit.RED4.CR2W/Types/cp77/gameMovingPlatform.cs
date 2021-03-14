using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatform : entIPlacedComponent
	{
		private CEnum<gameMovingPlatformLoopType> _loopType;

		[Ordinal(5)] 
		[RED("loopType")] 
		public CEnum<gameMovingPlatformLoopType> LoopType
		{
			get
			{
				if (_loopType == null)
				{
					_loopType = (CEnum<gameMovingPlatformLoopType>) CR2WTypeManager.Create("gameMovingPlatformLoopType", "loopType", cr2w, this);
				}
				return _loopType;
			}
			set
			{
				if (_loopType == value)
				{
					return;
				}
				_loopType = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
