using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureCompensationAreaSettings : IAreaSettings
	{
		private CFloat _exposureCompensation;

		[Ordinal(2)] 
		[RED("exposureCompensation")] 
		public CFloat ExposureCompensation
		{
			get
			{
				if (_exposureCompensation == null)
				{
					_exposureCompensation = (CFloat) CR2WTypeManager.Create("Float", "exposureCompensation", cr2w, this);
				}
				return _exposureCompensation;
			}
			set
			{
				if (_exposureCompensation == value)
				{
					return;
				}
				_exposureCompensation = value;
				PropertySet(this);
			}
		}

		public ExposureCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
