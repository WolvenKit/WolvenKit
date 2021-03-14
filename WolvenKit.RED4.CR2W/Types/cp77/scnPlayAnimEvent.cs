using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayAnimEvent : scnSceneEvent
	{
		private scneventsPlayAnimEventExData _animData;
		private scnPerformerId _performer;
		private CName _actorComponent;
		private CBool _convertToAdditive;
		private CEnum<animMuteAnimEvents> _muteAnimEvents;
		private CFloat _neckWeight;
		private CBool _upperFaceBlendAdditive;
		private CBool _lowerFaceBlendAdditive;
		private CBool _eyesBlendAdditive;

		[Ordinal(6)] 
		[RED("animData")] 
		public scneventsPlayAnimEventExData AnimData
		{
			get
			{
				if (_animData == null)
				{
					_animData = (scneventsPlayAnimEventExData) CR2WTypeManager.Create("scneventsPlayAnimEventExData", "animData", cr2w, this);
				}
				return _animData;
			}
			set
			{
				if (_animData == value)
				{
					return;
				}
				_animData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("actorComponent")] 
		public CName ActorComponent
		{
			get
			{
				if (_actorComponent == null)
				{
					_actorComponent = (CName) CR2WTypeManager.Create("CName", "actorComponent", cr2w, this);
				}
				return _actorComponent;
			}
			set
			{
				if (_actorComponent == value)
				{
					return;
				}
				_actorComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("convertToAdditive")] 
		public CBool ConvertToAdditive
		{
			get
			{
				if (_convertToAdditive == null)
				{
					_convertToAdditive = (CBool) CR2WTypeManager.Create("Bool", "convertToAdditive", cr2w, this);
				}
				return _convertToAdditive;
			}
			set
			{
				if (_convertToAdditive == value)
				{
					return;
				}
				_convertToAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("muteAnimEvents")] 
		public CEnum<animMuteAnimEvents> MuteAnimEvents
		{
			get
			{
				if (_muteAnimEvents == null)
				{
					_muteAnimEvents = (CEnum<animMuteAnimEvents>) CR2WTypeManager.Create("animMuteAnimEvents", "muteAnimEvents", cr2w, this);
				}
				return _muteAnimEvents;
			}
			set
			{
				if (_muteAnimEvents == value)
				{
					return;
				}
				_muteAnimEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("neckWeight")] 
		public CFloat NeckWeight
		{
			get
			{
				if (_neckWeight == null)
				{
					_neckWeight = (CFloat) CR2WTypeManager.Create("Float", "neckWeight", cr2w, this);
				}
				return _neckWeight;
			}
			set
			{
				if (_neckWeight == value)
				{
					return;
				}
				_neckWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("upperFaceBlendAdditive")] 
		public CBool UpperFaceBlendAdditive
		{
			get
			{
				if (_upperFaceBlendAdditive == null)
				{
					_upperFaceBlendAdditive = (CBool) CR2WTypeManager.Create("Bool", "upperFaceBlendAdditive", cr2w, this);
				}
				return _upperFaceBlendAdditive;
			}
			set
			{
				if (_upperFaceBlendAdditive == value)
				{
					return;
				}
				_upperFaceBlendAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("lowerFaceBlendAdditive")] 
		public CBool LowerFaceBlendAdditive
		{
			get
			{
				if (_lowerFaceBlendAdditive == null)
				{
					_lowerFaceBlendAdditive = (CBool) CR2WTypeManager.Create("Bool", "lowerFaceBlendAdditive", cr2w, this);
				}
				return _lowerFaceBlendAdditive;
			}
			set
			{
				if (_lowerFaceBlendAdditive == value)
				{
					return;
				}
				_lowerFaceBlendAdditive = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("eyesBlendAdditive")] 
		public CBool EyesBlendAdditive
		{
			get
			{
				if (_eyesBlendAdditive == null)
				{
					_eyesBlendAdditive = (CBool) CR2WTypeManager.Create("Bool", "eyesBlendAdditive", cr2w, this);
				}
				return _eyesBlendAdditive;
			}
			set
			{
				if (_eyesBlendAdditive == value)
				{
					return;
				}
				_eyesBlendAdditive = value;
				PropertySet(this);
			}
		}

		public scnPlayAnimEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
