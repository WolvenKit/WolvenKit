using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleFastTravelAvailabilityOnMapRequest : gameScriptableSystemRequest
	{
		private CBool _isEnabled;
		private TweakDBID _pointRecord;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pointRecord")] 
		public TweakDBID PointRecord
		{
			get
			{
				if (_pointRecord == null)
				{
					_pointRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "pointRecord", cr2w, this);
				}
				return _pointRecord;
			}
			set
			{
				if (_pointRecord == value)
				{
					return;
				}
				_pointRecord = value;
				PropertySet(this);
			}
		}

		public ToggleFastTravelAvailabilityOnMapRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
