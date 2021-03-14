using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraQuestProperties : CVariable
	{
		private CName _factOnFeedReceived;
		private CName _questFactOnDetection;
		private CBool _isInFollowMode;
		private entEntityID _followedTargetID;

		[Ordinal(0)] 
		[RED("factOnFeedReceived")] 
		public CName FactOnFeedReceived
		{
			get
			{
				if (_factOnFeedReceived == null)
				{
					_factOnFeedReceived = (CName) CR2WTypeManager.Create("CName", "factOnFeedReceived", cr2w, this);
				}
				return _factOnFeedReceived;
			}
			set
			{
				if (_factOnFeedReceived == value)
				{
					return;
				}
				_factOnFeedReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("questFactOnDetection")] 
		public CName QuestFactOnDetection
		{
			get
			{
				if (_questFactOnDetection == null)
				{
					_questFactOnDetection = (CName) CR2WTypeManager.Create("CName", "questFactOnDetection", cr2w, this);
				}
				return _questFactOnDetection;
			}
			set
			{
				if (_questFactOnDetection == value)
				{
					return;
				}
				_questFactOnDetection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInFollowMode")] 
		public CBool IsInFollowMode
		{
			get
			{
				if (_isInFollowMode == null)
				{
					_isInFollowMode = (CBool) CR2WTypeManager.Create("Bool", "isInFollowMode", cr2w, this);
				}
				return _isInFollowMode;
			}
			set
			{
				if (_isInFollowMode == value)
				{
					return;
				}
				_isInFollowMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("followedTargetID")] 
		public entEntityID FollowedTargetID
		{
			get
			{
				if (_followedTargetID == null)
				{
					_followedTargetID = (entEntityID) CR2WTypeManager.Create("entEntityID", "followedTargetID", cr2w, this);
				}
				return _followedTargetID;
			}
			set
			{
				if (_followedTargetID == value)
				{
					return;
				}
				_followedTargetID = value;
				PropertySet(this);
			}
		}

		public CameraQuestProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
