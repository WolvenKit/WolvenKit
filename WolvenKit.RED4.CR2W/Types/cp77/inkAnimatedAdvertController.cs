using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkAnimatedAdvertController : inkWidgetLogicController
	{
		private CName _animName;
		private CEnum<inkanimLoopType> _loopType;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loopType")] 
		public CEnum<inkanimLoopType> LoopType
		{
			get
			{
				if (_loopType == null)
				{
					_loopType = (CEnum<inkanimLoopType>) CR2WTypeManager.Create("inkanimLoopType", "loopType", cr2w, this);
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

		public inkAnimatedAdvertController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
