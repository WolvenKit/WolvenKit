using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GetTargetLastKnownPosition : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _inTargetObject;
		private CHandle<AIArgumentMapping> _outPosition;
		private CFloat _predictionTime;

		[Ordinal(0)] 
		[RED("inTargetObject")] 
		public CHandle<AIArgumentMapping> InTargetObject
		{
			get
			{
				if (_inTargetObject == null)
				{
					_inTargetObject = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inTargetObject", cr2w, this);
				}
				return _inTargetObject;
			}
			set
			{
				if (_inTargetObject == value)
				{
					return;
				}
				_inTargetObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get
			{
				if (_outPosition == null)
				{
					_outPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outPosition", cr2w, this);
				}
				return _outPosition;
			}
			set
			{
				if (_outPosition == value)
				{
					return;
				}
				_outPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("predictionTime")] 
		public CFloat PredictionTime
		{
			get
			{
				if (_predictionTime == null)
				{
					_predictionTime = (CFloat) CR2WTypeManager.Create("Float", "predictionTime", cr2w, this);
				}
				return _predictionTime;
			}
			set
			{
				if (_predictionTime == value)
				{
					return;
				}
				_predictionTime = value;
				PropertySet(this);
			}
		}

		public GetTargetLastKnownPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
