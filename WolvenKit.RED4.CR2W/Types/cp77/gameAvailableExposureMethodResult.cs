using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAvailableExposureMethodResult : CVariable
	{
		private CFloat _distanceToTarget;
		private CEnum<AICoverExposureMethod> _method;

		[Ordinal(0)] 
		[RED("distanceToTarget")] 
		public CFloat DistanceToTarget
		{
			get
			{
				if (_distanceToTarget == null)
				{
					_distanceToTarget = (CFloat) CR2WTypeManager.Create("Float", "distanceToTarget", cr2w, this);
				}
				return _distanceToTarget;
			}
			set
			{
				if (_distanceToTarget == value)
				{
					return;
				}
				_distanceToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("method")] 
		public CEnum<AICoverExposureMethod> Method
		{
			get
			{
				if (_method == null)
				{
					_method = (CEnum<AICoverExposureMethod>) CR2WTypeManager.Create("AICoverExposureMethod", "method", cr2w, this);
				}
				return _method;
			}
			set
			{
				if (_method == value)
				{
					return;
				}
				_method = value;
				PropertySet(this);
			}
		}

		public gameAvailableExposureMethodResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
