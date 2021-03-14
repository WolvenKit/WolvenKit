using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationData : CVariable
	{
		private CName _animationName;
		private CEnum<ETransformAnimationOperationType> _operationType;
		private STransformAnimationPlayEventData _playData;
		private STransformAnimationSkipEventData _skipData;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<ETransformAnimationOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<ETransformAnimationOperationType>) CR2WTypeManager.Create("ETransformAnimationOperationType", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playData")] 
		public STransformAnimationPlayEventData PlayData
		{
			get
			{
				if (_playData == null)
				{
					_playData = (STransformAnimationPlayEventData) CR2WTypeManager.Create("STransformAnimationPlayEventData", "playData", cr2w, this);
				}
				return _playData;
			}
			set
			{
				if (_playData == value)
				{
					return;
				}
				_playData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("skipData")] 
		public STransformAnimationSkipEventData SkipData
		{
			get
			{
				if (_skipData == null)
				{
					_skipData = (STransformAnimationSkipEventData) CR2WTypeManager.Create("STransformAnimationSkipEventData", "skipData", cr2w, this);
				}
				return _skipData;
			}
			set
			{
				if (_skipData == value)
				{
					return;
				}
				_skipData = value;
				PropertySet(this);
			}
		}

		public STransformAnimationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
