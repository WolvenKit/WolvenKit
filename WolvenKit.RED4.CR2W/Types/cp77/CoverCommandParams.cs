using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoverCommandParams : IScriptable
	{
		private CArray<CEnum<AICoverExposureMethod>> _exposureMethods;

		[Ordinal(0)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get
			{
				if (_exposureMethods == null)
				{
					_exposureMethods = (CArray<CEnum<AICoverExposureMethod>>) CR2WTypeManager.Create("array:AICoverExposureMethod", "exposureMethods", cr2w, this);
				}
				return _exposureMethods;
			}
			set
			{
				if (_exposureMethods == value)
				{
					return;
				}
				_exposureMethods = value;
				PropertySet(this);
			}
		}

		public CoverCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
