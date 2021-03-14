using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDetectionParams : CVariable
	{
		private CFloat _detectionProgress;

		[Ordinal(0)] 
		[RED("detectionProgress")] 
		public CFloat DetectionProgress
		{
			get
			{
				if (_detectionProgress == null)
				{
					_detectionProgress = (CFloat) CR2WTypeManager.Create("Float", "detectionProgress", cr2w, this);
				}
				return _detectionProgress;
			}
			set
			{
				if (_detectionProgress == value)
				{
					return;
				}
				_detectionProgress = value;
				PropertySet(this);
			}
		}

		public gameuiDetectionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
