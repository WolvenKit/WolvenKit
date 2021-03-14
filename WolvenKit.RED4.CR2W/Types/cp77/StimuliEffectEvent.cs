using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StimuliEffectEvent : redEvent
	{
		private CName _stimuliEventName;
		private Vector4 _targetPoint;

		[Ordinal(0)] 
		[RED("stimuliEventName")] 
		public CName StimuliEventName
		{
			get
			{
				if (_stimuliEventName == null)
				{
					_stimuliEventName = (CName) CR2WTypeManager.Create("CName", "stimuliEventName", cr2w, this);
				}
				return _stimuliEventName;
			}
			set
			{
				if (_stimuliEventName == value)
				{
					return;
				}
				_stimuliEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetPoint")] 
		public Vector4 TargetPoint
		{
			get
			{
				if (_targetPoint == null)
				{
					_targetPoint = (Vector4) CR2WTypeManager.Create("Vector4", "targetPoint", cr2w, this);
				}
				return _targetPoint;
			}
			set
			{
				if (_targetPoint == value)
				{
					return;
				}
				_targetPoint = value;
				PropertySet(this);
			}
		}

		public StimuliEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
