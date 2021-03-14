using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplAnimTransformPlayRequest : gameReplAnimTransformRequestBase
	{
		private CName _animName;
		private CFloat _timeScale;
		private CInt32 _timesToPlay;

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
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CInt32 TimesToPlay
		{
			get
			{
				if (_timesToPlay == null)
				{
					_timesToPlay = (CInt32) CR2WTypeManager.Create("Int32", "timesToPlay", cr2w, this);
				}
				return _timesToPlay;
			}
			set
			{
				if (_timesToPlay == value)
				{
					return;
				}
				_timesToPlay = value;
				PropertySet(this);
			}
		}

		public gameReplAnimTransformPlayRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
