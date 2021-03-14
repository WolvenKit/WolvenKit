using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RoadBlock : animAnimFeature
	{
		private CBool _isOpening;
		private CFloat _duration;
		private CBool _initOpen;

		[Ordinal(0)] 
		[RED("isOpening")] 
		public CBool IsOpening
		{
			get
			{
				if (_isOpening == null)
				{
					_isOpening = (CBool) CR2WTypeManager.Create("Bool", "isOpening", cr2w, this);
				}
				return _isOpening;
			}
			set
			{
				if (_isOpening == value)
				{
					return;
				}
				_isOpening = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("initOpen")] 
		public CBool InitOpen
		{
			get
			{
				if (_initOpen == null)
				{
					_initOpen = (CBool) CR2WTypeManager.Create("Bool", "initOpen", cr2w, this);
				}
				return _initOpen;
			}
			set
			{
				if (_initOpen == value)
				{
					return;
				}
				_initOpen = value;
				PropertySet(this);
			}
		}

		public AnimFeature_RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
