using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformSkipRequest : gameReplAnimTransformRequestBase
	{
		private CName _animName;
		private CFloat _skipTime;

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
		[RED("skipTime")] 
		public CFloat SkipTime
		{
			get
			{
				if (_skipTime == null)
				{
					_skipTime = (CFloat) CR2WTypeManager.Create("Float", "skipTime", cr2w, this);
				}
				return _skipTime;
			}
			set
			{
				if (_skipTime == value)
				{
					return;
				}
				_skipTime = value;
				PropertySet(this);
			}
		}

		public gameReplAnimTransformSkipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
