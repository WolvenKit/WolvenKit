using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationTrackItem : ISerializable
	{
		private CHandle<gameTransformAnimationTrackItemImpl> _impl;
		private CFloat _startTime;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("impl")] 
		public CHandle<gameTransformAnimationTrackItemImpl> Impl
		{
			get
			{
				if (_impl == null)
				{
					_impl = (CHandle<gameTransformAnimationTrackItemImpl>) CR2WTypeManager.Create("handle:gameTransformAnimationTrackItemImpl", "impl", cr2w, this);
				}
				return _impl;
			}
			set
			{
				if (_impl == value)
				{
					return;
				}
				_impl = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startTime")] 
		public CFloat StartTime
		{
			get
			{
				if (_startTime == null)
				{
					_startTime = (CFloat) CR2WTypeManager.Create("Float", "startTime", cr2w, this);
				}
				return _startTime;
			}
			set
			{
				if (_startTime == value)
				{
					return;
				}
				_startTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimationTrackItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
