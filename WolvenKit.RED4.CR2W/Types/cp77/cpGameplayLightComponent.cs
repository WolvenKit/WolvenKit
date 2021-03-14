using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpGameplayLightComponent : entLightComponent
	{
		private CBool _reactToTime;
		private GameTime _begin;
		private GameTime _end;
		private CFloat _probability;
		private GameTime _delayRange;

		[Ordinal(54)] 
		[RED("reactToTime")] 
		public CBool ReactToTime
		{
			get
			{
				if (_reactToTime == null)
				{
					_reactToTime = (CBool) CR2WTypeManager.Create("Bool", "reactToTime", cr2w, this);
				}
				return _reactToTime;
			}
			set
			{
				if (_reactToTime == value)
				{
					return;
				}
				_reactToTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get
			{
				if (_begin == null)
				{
					_begin = (GameTime) CR2WTypeManager.Create("GameTime", "begin", cr2w, this);
				}
				return _begin;
			}
			set
			{
				if (_begin == value)
				{
					return;
				}
				_begin = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("end")] 
		public GameTime End
		{
			get
			{
				if (_end == null)
				{
					_end = (GameTime) CR2WTypeManager.Create("GameTime", "end", cr2w, this);
				}
				return _end;
			}
			set
			{
				if (_end == value)
				{
					return;
				}
				_end = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get
			{
				if (_probability == null)
				{
					_probability = (CFloat) CR2WTypeManager.Create("Float", "probability", cr2w, this);
				}
				return _probability;
			}
			set
			{
				if (_probability == value)
				{
					return;
				}
				_probability = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("delayRange")] 
		public GameTime DelayRange
		{
			get
			{
				if (_delayRange == null)
				{
					_delayRange = (GameTime) CR2WTypeManager.Create("GameTime", "delayRange", cr2w, this);
				}
				return _delayRange;
			}
			set
			{
				if (_delayRange == value)
				{
					return;
				}
				_delayRange = value;
				PropertySet(this);
			}
		}

		public cpGameplayLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
